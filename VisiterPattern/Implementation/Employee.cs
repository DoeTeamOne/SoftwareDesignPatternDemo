using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisiterPattern.Abstruction;

namespace VisiterPattern.Implementation
{
    /// <summary>
    /// concerete Element
    /// </summary>
    public class Employee:IElement
    {
        public decimal AmountOrdered { get; private set; }
        public decimal Discount { get; set; }
        public string Name { get; set; }
        public int  YearsEmployed { get; set; }
        public Employee(string name, decimal amountOrdered)
        {
            Name = name;
            AmountOrdered = amountOrdered;
        }
        public void Accept(IVisitor visiter)
        {
            visiter.Visit(this);
            Console.WriteLine($"Visited {nameof(Employee)}{Name},discount Given :{Discount}");
        }
    }
}
