using AbstructFactoryPattern.Abstruction;

namespace AbstructFactoryPattern.Implimentation
{
    public class EthShippingCostsServices : IShippingCostsService
    {
        public decimal ShippingCosts => 10;
    }
}
