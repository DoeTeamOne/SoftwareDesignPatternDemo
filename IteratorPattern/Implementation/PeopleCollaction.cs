using IteratorPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Implementation
{
    /// <summary>
    /// Concerete Aggrigate 
    /// </summary>
    public class PeopleCollaction : List<Person>, IPeopleCollaction
    {
        public IPeopleIterator CreateIterator()
        {
            return new PeopleIterator(this);
        }
    }
}
