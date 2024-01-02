using FactoryMethod_Patern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Patern.Implmentation
{
    // <summary>
    /// concerete Implementation One 
    /// </summary>
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryID;
        public CountryDiscountService(string countryID)
        {
            _countryID = countryID;

        }
        public override int DiscountPercentage
        {
            get
            {
                switch (_countryID)
                {
                    case "ET":
                        return 20;
                    case "ES":
                        return 30;
                    default:
                        return 0;

                }
            }
        }

    }
}
