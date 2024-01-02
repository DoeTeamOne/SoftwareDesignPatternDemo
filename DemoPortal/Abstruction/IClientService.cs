using DemoPortal.Implementation;
namespace DemoPortal.Abstruction

{
    public interface IClientService
    {
        List<Discount> GetAllDiscounts();
        void SetClientData(string countryCode, string DiscountCode);
    }
}
