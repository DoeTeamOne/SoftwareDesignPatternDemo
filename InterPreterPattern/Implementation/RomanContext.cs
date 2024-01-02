using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterPreterPattern.Implementation
{
    public class RomanContext
    {
        public int Input { get; set; }
        public string Output { get; set; } = string.Empty;
        public RomanContext(int input)
        {
            Input = input;
        }
    }
}
