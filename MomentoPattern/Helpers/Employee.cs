using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentoPattern.Helpers
{
    
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Employee(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }


        public class Manager : Employee
        {
            public List<Employee> Employees = new List<Employee>();
            public Manager(int id, string name) : base(id, name)
            {

            }

        }
    
}
