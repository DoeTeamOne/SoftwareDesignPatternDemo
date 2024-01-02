using MediatorPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Implementation
{
    public class Lawyer:TeamMember
    {
        public Lawyer(string name):base(name) 
        {
        
        }

        public override void Receive(string from, string Message)
        {
         Console.WriteLine( $"{nameof(Lawyer)} {Name} recived");
            base.Receive(from, Message);
        }
    }
}
