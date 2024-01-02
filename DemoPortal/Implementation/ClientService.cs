

using DemoPortal.Abstruction;
using FactoryMethod_Patern.Abstruction;
using FactoryMethod_Patern.Implmentation;

namespace DemoPortal.Implementation
{
    public class ClientService : IClientService
    {
        private List<DiscountFactory> factories;
          string _coutryCode;
          string _discountCode;
        List<Discount> discounts = new List<Discount>();
        public ClientService() 
        {
           
        }

        public void SetClientData(string countryCode, string DiscountCode)
        {
            _coutryCode = countryCode;
            _discountCode = DiscountCode;
            factories = new List<DiscountFactory>()
                {
                new CodeDiscountFactory(_discountCode),
                new CountryDiscountFactory(_coutryCode)
                };
        }

        public List<Discount> GetAllDiscounts()
        {
            foreach(var factory in factories)
            {
               var discountServices = factory.CreateDiscountServices();

                var discountinfo = new Discount
                {
                    Name = discountServices.ToString(),
                    Percentage = discountServices.DiscountPercentage
                };
                discounts.Add(discountinfo);    
            }
            return discounts;
        }
    }


    public class Discount
    {
        public string Name { get; set; }
        public int Percentage { get; set; }
    }
}
