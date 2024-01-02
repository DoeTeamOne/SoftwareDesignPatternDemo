using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubSystems
{
    public  class OrderServices
    {
        public bool HasEnoughOrders(int CustomerID)
        {
            // Fake Implementation
            return (CustomerID > 5); 
        }
    }
}
