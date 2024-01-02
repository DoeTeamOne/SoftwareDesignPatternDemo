using AbstructFactoryPattern.Abstruction;

namespace AbstructFactoryPattern.Implimentation
{
    public class EthShoppingCartPurchaseFactory : ISoppingCartPurchaseFactory
    {
        public IDscountService CreateDiscountService()
        {
            return new EthDiscountService();
        }

        public IShippingCostsService CreateShippingCostsService()
        {
           return new EthShippingCostsServices();
        }
    }
}
