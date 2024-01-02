using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisiterPattern.Abstruction
{
    public interface IElement
    {
        void Accept(IVisitor visiter);
    }
}
