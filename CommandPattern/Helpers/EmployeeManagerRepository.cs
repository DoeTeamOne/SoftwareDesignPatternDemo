using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Helpers
{
    public class EmployeeManagerRepository : IEmployeeManagerRepository
    {
        private List<Manager> _managers = new List<Manager>()
        {
            new Manager( 1,"Dan"),
            new Manager(2,"Jhon")
        };
        public void AddEmployee(int managerId, Employee employee)
        {
            _managers.First(m => m.Id == managerId).Employees.Add(employee);
        }

        public bool HasEmployee(int managerId, int employeeId)
        {
            return _managers.First(m => m.Id == managerId).Employees.Any(e => e.Id == employeeId);
        }

        public void RemoveEmployee(int ManagerId, Employee employee)
        {
            _managers.First(m => m.Id == ManagerId).Employees.Remove(employee);
        }

        public void WriteDataStore()
        {
            foreach (var manager in _managers)
            {
                Console.WriteLine($"Manager {manager.Id}, {manager.Name}");
                if (manager.Employees.Any())
                {
                    foreach (var employee in manager.Employees)
                    {
                        Console.WriteLine($"Employee {employee.Id} , {employee.Name}");
                    }
                }
                else
                {
                    Console.WriteLine($"No Employee");
                }
            }

        }

        public List<Manager> GetManagersData()
        {
            return _managers;
        }

    }
}
