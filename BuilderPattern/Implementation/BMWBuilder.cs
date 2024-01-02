using BuilderPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Implementation
{
    public class BMWBuilder : CarBuilder
    {
        public BMWBuilder() : base("BMW")
        {

        }
        public override void BuildEngine()
        { 
            Car.AddPart("'a Fancy V8 Engine'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'5-door with metalic finish'");
        }
    }
}
