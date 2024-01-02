using MomentoPattern.Abstruction;
using MomentoPattern.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICommand = MomentoPattern.Abstruction.ICommand;
namespace MomentoPattern.Implementation
{
    /// <summary>
    /// Concerete Command and Originator
    /// </summary>
    public class AddEmployeeToManagerList: ICommand
    {
        private readonly IEmployeeManagerRepository _employeeManagerRepository;
        private int _managerid;
        private  Employee? _employee;
        public AddEmployeeToManagerList(IEmployeeManagerRepository employeeManagerRepository, int managerid, Employee? employee)
        {
            _employeeManagerRepository = employeeManagerRepository;
            _managerid = managerid;
            _employee = employee;
        }

        public  AddEmployeeToManagerListMomento CreateMomento()
        {
            return new AddEmployeeToManagerListMomento(_managerid, _employee);
        }

        public void RestoreMomento(AddEmployeeToManagerListMomento momento)
        {
            _managerid = momento.ManagerId;
            _employee = momento.Employee;
        }
        public bool CanExcute()
        {
            if (_employee == null)
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
            if (_employee == null)
            {
                return;
            }
            _employeeManagerRepository.RemoveEmployee(_managerid, _employee);
        }
    }
}
