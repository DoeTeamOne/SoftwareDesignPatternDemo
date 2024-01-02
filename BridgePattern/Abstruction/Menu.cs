using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstruction
{
    public abstract class Menu
    {
        public readonly ICupon _cupon = null!;
        public abstract int CalculatePrice();
        public Menu(ICupon cupon)
        {
            _cupon = cupon;
        }


    }
}
