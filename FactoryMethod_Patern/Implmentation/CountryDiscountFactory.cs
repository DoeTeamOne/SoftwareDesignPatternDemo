using FactoryMethod_Patern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Patern.Implmentation
{
    /// <summary>
    /// Creator for country Discount
    /// </summary>
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryID;

        public CountryDiscountFactory(string CointryID)
        {
            _countryID = CointryID;
        }
        public override DiscountService CreateDiscountServices()
        {
            return new CountryDiscountService(_countryID);
        }
    }
}
