using MomentoPattern.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentoPattern.Abstruction
{
    public interface IEmployeeManagerRepository
    {
        void AddEmployee(int managerId, Employee employee);
        void RemoveEmployee(int ManagerId, Employee employee);
        bool HasEmployee(int managerId, int employeeId);
        void WriteDataStore();
        List<Manager> GetManagersData();
    }
}
