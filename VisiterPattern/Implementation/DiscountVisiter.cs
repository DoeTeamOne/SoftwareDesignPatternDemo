using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisiterPattern.Abstruction;

namespace VisiterPattern.Implementation
{
    /// <summary>
    /// concerete Visiter
    /// </summary>
    public class DiscountVisiter : IVisitor
    {
        public decimal TotalDiscountGven { get; set; }

        public void Visit(IElement element)
        {
            if (element is  Customer)
            {
                VisitCustomer((Customer)element);
            }
            else if (element is Employee)
            {
                VisitEmployee((Employee)element);
            }
        }

        private void VisitCustomer(Customer customer)
        {
            // percentage of total amount
            var discount = customer.AmountOrdered / 10;

            //set customer discount
            customer.Discount = discount;
            TotalDiscountGven += discount;
        }

        private void VisitEmployee(Employee employee)
        {
            // fixed value depending on the amount of years employed
            var discount = employee.YearsEmployed <10?100:200;

            employee.Discount = discount;
            TotalDiscountGven += discount;
        }
    }
}
