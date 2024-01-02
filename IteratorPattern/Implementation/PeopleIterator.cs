using IteratorPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Implementation
{
    /// <summary>
    /// Concrete Iterator 
    /// </summary>
    public class PeopleIterator : IPeopleIterator
    {
        private readonly PeopleCollaction _peoplecollection;
        private  int _current = 0;

        public PeopleIterator(PeopleCollaction collection) 
        {
            _peoplecollection = collection;
        }
        public bool ISDone
        {
            // Returns if the  curont index is greater or equal to the collaction count
            get { return _current >= _peoplecollection.Count; }
        }

        public Person CurrentItem
        {
            get
            {
                return _peoplecollection.OrderBy(p => p.Name).ToList()[_current];
            }
        }

        public Person First()
        {
            _current=0; 
            return _peoplecollection.OrderBy(p => p.Name).ToList()[_current]; // order by name and Return peron at index zero
        }

        public Person Next()
        {
            _current++;
            if(!ISDone)
            {
                return _peoplecollection.OrderBy(p => p.Name).ToList()[_current];
            }
            else
            {
                return null;
            }
        }
    }
}
