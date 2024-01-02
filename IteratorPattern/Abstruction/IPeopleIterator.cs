using IteratorPattern.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Abstruction
{
    public interface IPeopleIterator
    {
        Person First();
        Person Next();
        bool ISDone { get; }
        Person CurrentItem { get; }
    }
}
