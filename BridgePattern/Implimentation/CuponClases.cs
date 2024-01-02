using BridgePattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Implimentation
{
    public class NoCupon : ICupon
    {
        public int CuponValue { get => 0; }
    }
    public class OneEruoCupon : ICupon
    {
        //gives one euro discount
        public int CuponValue { get=>1; }
    }

    public class TwoEruoCupon : ICupon
    {
        //gives two euro discount
        public int CuponValue { get => 2; }
    }
}
