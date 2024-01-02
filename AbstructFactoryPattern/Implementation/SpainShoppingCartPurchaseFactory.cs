using AbstructFactoryPattern.Abstruction;

namespace AbstructFactoryPattern.Implimentation
{
    /// <summary>
    /// this class is responsible for creating shopping cart for spain
    /// </summary>
    public class SpainShoppingCartPurchaseFactory : ISoppingCartPurchaseFactory
    {
       
        public IDscountService CreateDiscountService()
        {
            return new SpainDiscountService();
        }

        public IShippingCostsService CreateShippingCostsService()
        {
            return new SpainShippingCostsService();
        }
    }
}
