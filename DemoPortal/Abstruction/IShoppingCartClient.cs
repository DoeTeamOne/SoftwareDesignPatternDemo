namespace DemoPortal.Abstruction
{
    public interface IShoppingCartClient
    {
        public Decimal CalculateCost();
        public void SetOrderCost(decimal amount);
    }
}
