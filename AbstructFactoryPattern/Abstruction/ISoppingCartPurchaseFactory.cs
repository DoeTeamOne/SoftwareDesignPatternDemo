using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactoryPattern.Abstruction
{
    /// <summary>
    /// this is abstruct factory
    /// </summary>
    public interface ISoppingCartPurchaseFactory
    {
        IDscountService CreateDiscountService();
     
        IShippingCostsService CreateShippingCostsService();

    }

    public interface IDscountService
    {
      int DiscountPercentage { get; }
    }

    public interface IShippingCostsService
    {
        decimal ShippingCosts { get; }  
    }

}
