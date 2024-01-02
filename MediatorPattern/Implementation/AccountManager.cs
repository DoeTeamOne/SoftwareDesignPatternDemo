using MediatorPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Implementation
{
  
    public class AccountManager : TeamMember
    {
        public AccountManager(string name) : base(name)
        {

        }

        public override void Receive(string from, string Message)
        {
            base.Receive(from, Message);
            Console.WriteLine( $"{nameof(AccountManager)} {Name} recived"); 
        }
    }
}
