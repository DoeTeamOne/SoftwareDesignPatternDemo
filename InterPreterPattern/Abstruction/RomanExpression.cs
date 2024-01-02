using InterPreterPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterPreterPattern.Abstruction
{
    public abstract class RomanExpression
    {
        public abstract void Interpret(RomanContext value);
        
    }
}
