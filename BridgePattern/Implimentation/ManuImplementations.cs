using BridgePattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implimentation
{
    public class VeganMenu : Menu
    {
        public VeganMenu(ICupon cupon):base(cupon) 
        {
         // using constructor we set the cuppon Value on the base class :)
        }
        public override int CalculatePrice()
        {
            return 20 - _cupon.CuponValue; // we get the cupo value from base 

        }
    }

    public class MeatBasedMenu : Menu
    {
        public MeatBasedMenu(ICupon cupon):base (cupon) 
        { 
        }
        public override int CalculatePrice()
        {
            return 30 - _cupon.CuponValue;
        }
    }
}
