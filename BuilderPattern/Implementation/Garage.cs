using BuilderPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Implementation
{
    public class Garage
    {
        private CarBuilder? _Builder;
        public Garage()
        {

        }
        public void Construct(CarBuilder Builder)
        {
            _Builder = Builder;
            _Builder.BuildFrame();
            _Builder.BuildEngine();
        }

        public string Show()
        {
            return _Builder.Car.ToString();
            
        }
    }
}
