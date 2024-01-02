using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Implementation
{
    public class Car
    {
        private readonly List<string> _parts = new();
        private readonly string _cartype;
        public Car(string cartype)
        { 
            _cartype = cartype;
        }

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public override string ToString()
        {
            var sb  = new StringBuilder();
            foreach (var part in _parts)
            {
                sb.Append($"Car Type {_cartype} has Part {part}");
            }
           return sb.ToString();
        }


    }
}
