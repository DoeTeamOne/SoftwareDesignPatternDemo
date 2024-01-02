using FactoryMethod_Patern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Patern.Implmentation
{
    /// <summary>
    /// Concrete Implementation Two
    /// </summary>
    public class CodeDiscountService : DiscountService
    {
        private readonly string _code;
        List<string> ValidCodes = new List<string>   // sample Data
        {
            "PROMO12023",
            "PROMO22023"
        };

        public CodeDiscountService(string code)
        {
            _code = code;

        }
        public override int DiscountPercentage
        {
            get
            {
                return ValidCodes.Contains(_code) ? 15 : 0; // if the code is valid 15% discount 
            }
        }
    }
}
