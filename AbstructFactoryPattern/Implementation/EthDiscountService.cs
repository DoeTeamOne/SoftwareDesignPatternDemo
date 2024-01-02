using AbstructFactoryPattern.Abstruction;

namespace AbstructFactoryPattern.Implimentation
{
    public class EthDiscountService : IDscountService
    {
        int IDscountService.DiscountPercentage => 10;
    }
}
