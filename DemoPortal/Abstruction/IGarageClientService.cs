using BuilderPattern.Abstruction;

namespace DemoPortal.Abstruction
{
    public interface IGarageClientService
    {
        string GetCarInfo();
        void ConstructCar(CarBuilder carBuilder);
    }
}
