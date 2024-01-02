using AbstructFactoryPattern.Abstruction;

namespace AbstructFactoryPattern.Implimentation
{
    public class SpainDiscountService : IDscountService
    {
        public int DiscountPercentage => 20;
    }
}
