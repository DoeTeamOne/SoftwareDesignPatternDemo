using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Patern.Abstruction
{
    
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }

        public override string ToString() => GetType().Name;

    }
}
