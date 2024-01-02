using ObserverPattern.Abstruction;
using ObserverPattern.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Implementation
{
    /// <summary>
    /// Concerete Subjuct
    /// </summary>
    public  class TicketResalerServices:ITicketChangeListner
    {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange)
        {
            Console.WriteLine($"{nameof(TicketResalerServices)} notified of Ticket Change  : artist {ticketChange.ArtistId},amount {ticketChange.Amount}");
        }

    }
}
