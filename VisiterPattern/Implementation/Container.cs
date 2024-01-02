using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisiterPattern.Abstruction;

namespace VisiterPattern.Implementation
{
    public class Container
    {
        public List<Employee> Employees = new();
        public List<Customer> Customers = new();
        public void Accept(IVisitor visitor)
        {
            foreach (var employee in Employees)
            {
                employee.Accept(visitor);
            }
            foreach (var customer in Customers)
            {
                customer.Accept(visitor);
            }
        }
    }
}
