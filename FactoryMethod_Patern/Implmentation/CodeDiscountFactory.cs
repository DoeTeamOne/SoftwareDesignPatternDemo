using FactoryMethod_Patern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Patern.Implmentation
{
    // <summary>
    /// Creator for Our Code Discount
    /// </summary>
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly string _code;
        public CodeDiscountFactory(string Code)
        {
            _code = Code;
        }
        public override DiscountService CreateDiscountServices()
        {
            return new CodeDiscountService(_code);
        }
    }
}
