using ObserverPattern.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Abstruction
{
    public interface ITicketChangeListner
    {
        void ReceiveTicketChangeNotification(TicketChange ticketChange);
    }
}
