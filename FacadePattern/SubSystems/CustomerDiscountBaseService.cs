using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubSystems
{
    public class CustomerDiscountBaseService
    {
         public double CalculateDiscountBase(int CustomerID)
        {
            // fake Implimentation for the demo 
            return (CustomerID > 8) ? 10 : 20;
        }
    }
}
