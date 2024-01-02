using MomentoPattern.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentoPattern.Implementation
{
    public class AddEmployeeToManagerListMomento
    {
        public int ManagerId { get; set; }
        public Employee? Employee { get; private set; }
        public AddEmployeeToManagerListMomento(int managerid, Employee?employee) 
        {
            ManagerId = managerid;
            Employee = employee;
        }
    }
}
