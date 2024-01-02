using CommandPattern.Abstraction;
using CommandPattern.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandPattern.Implementation
{
    public class AddEmployeeToManagerList : Abstraction.ICommand
    {
        private readonly IEmployeeManagerRepository _employeeManagerRepository;
        private readonly int _managerid;
        private readonly Employee? _employee;

        public AddEmployeeToManagerList(IEmployeeManagerRepository employeeManagerRepository,int managerid, Employee? employee)
        {
            _employeeManagerRepository = employeeManagerRepository;
            _managerid = managerid;
            _employee = employee;
        }
        public bool CanExcute()
        {
            if(_employee == null)
            {
                return false;
            }
            // employee shouldn't be on the manager List alrady
            if (_employeeManagerRepository.HasEmployee(_managerid, _employee.Id))
            {
                return false;
            }
            return true;
        }

        public void Execute()
        {
            if (_employee == null)
            {
                return;
            }
            _employeeManagerRepository.AddEmployee(_managerid, _employee);
        }
        public void Undo()
        {
            if(_employee == null)
            {
                return;
            }
            _employeeManagerRepository.RemoveEmployee(_managerid,_employee);
        }
    }
}
