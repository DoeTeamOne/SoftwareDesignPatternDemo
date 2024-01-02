using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern.Interface
{
    public  interface ICharacter
    {
        string Draw(string fontfamily, int fontsize);
    }
}
