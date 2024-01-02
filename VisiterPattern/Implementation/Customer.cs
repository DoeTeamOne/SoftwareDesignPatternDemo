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
    public  class Customer:IElement
    { 

        public decimal AmountOrdered { get; private set; }
        public decimal Discount { get; set; }
        public string Name { get; set; }
        public Customer(string name,decimal amountOrdered) 
        {   
            Name = name;
            AmountOrdered = amountOrdered;
        }

        public void Accept(IVisitor visiter)
        {
            visiter.Visit(this);
            Console.WriteLine($"Visited {nameof(Customer)}{Name},discount Given :{Discount}");
        }
    }
}
