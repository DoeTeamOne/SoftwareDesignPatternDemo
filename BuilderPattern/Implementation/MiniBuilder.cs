using BuilderPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Implementation
{
    public class MiniBuilder : CarBuilder
    {
       public MiniBuilder() : base("Mini")
        {

        }

        public override void BuildEngine()
        {
            Car.AddPart("'Not a V8'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'3-door with stripes'");
        }
    }
}
