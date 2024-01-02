using BuilderPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Abstruction
{
    public abstract class CarBuilder
    {
        public Car Car { get; private set; }
        public CarBuilder(string cartype) 
        {
            Car = new Car(cartype);
        }
        public abstract void BuildEngine();
        public abstract void BuildFrame();
    }
}
