using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Abstruction
{
    public interface IPeopleCollaction
    {
        IPeopleIterator CreateIterator();
    }
}
