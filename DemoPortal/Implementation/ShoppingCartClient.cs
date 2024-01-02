

using AbstructFactoryPattern.Abstruction;
using DemoPortal.Abstruction;

namespace DemoPortal.Implementation
{
    public class ShoppingCartClient : IShoppingCartClient
    {
        private readonly IDscountService discountServices;
        private readonly IShippingCostsService shippingCostsService;
        public decimal costAmount;
        public ShoppingCartClient(ISoppingCartPurchaseFactory factory) 
        { 

        discountServices=  factory.CreateDiscountService();
        shippingCostsService= factory.CreateShippingCostsService();
           
        }

        public decimal CalculateCost()
        {
            var totalprice =  costAmount - (costAmount/100* discountServices.DiscountPercentage) + shippingCostsService.ShippingCosts;
            return totalprice;
        }

        public void SetOrderCost(decimal amount)
        {
            costAmount = amount;
        }
    }
}
