using InterPreterPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterPreterPattern.Implementation
{
    public class RomanTenExpression : RomanExpression
    {
        /******************************Roman Ten Expression*/
        // 90 = XC
        // 80 = LIII
        //70 = LII
        //  60 = LX
        // 50 = L
        // 40 = XL
        //  30 =XXX
        // 20 = XX
        // 10 = X
        /********************************Roman Ten Simplified*/

        // 90 = XC
        //50 = L
        // 40 =XL
        //10 =X

        public override void Interpret(RomanContext value)
        {
            while ((value.Input -90)>=0)
            {
                value.Output += "XC";
                value.Input -= 90;

            }
            while ((value.Input - 50) >= 0)
            {
                value.Output += "L";
                value.Input -= 50;

            }
            while ((value.Input - 40) >= 0)
            {
                value.Output += "XL";
                value.Input -= 40;

            }
            while ((value.Input - 10) >= 0)
            {
                value.Output += "X";
                value.Input -= 10;

            }

        }
    }
}
