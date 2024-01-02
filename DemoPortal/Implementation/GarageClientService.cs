using BuilderPattern.Abstruction;
using BuilderPattern.Implementation;
using DemoPortal.Abstruction;

namespace DemoPortal.Implementation
{
    public class GarageClientService : IGarageClientService
    {
        Garage _garage = new Garage();

        
        public void ConstructCar(CarBuilder carBuilder)
        {
            _garage.Construct(carBuilder);
        }
        public string GetCarInfo()
        {
            return _garage.Show();
        }
    }
}
