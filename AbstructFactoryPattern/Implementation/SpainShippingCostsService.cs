using AbstructFactoryPattern.Abstruction;

namespace AbstructFactoryPattern.Implimentation
{
    public class SpainShippingCostsService : IShippingCostsService
    {
        public decimal ShippingCosts => 20;
    }
}
