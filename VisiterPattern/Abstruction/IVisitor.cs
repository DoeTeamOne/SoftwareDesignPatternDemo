using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisiterPattern.Implementation;

namespace VisiterPattern.Abstruction
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}
