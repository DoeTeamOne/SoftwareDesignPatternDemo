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
    public class OrderServices:TicketChangeNotifier
    {
        public void CompleteTicketSale(int artistID, int amount)
        {
            // change Local Data storage ommited in demo implementation
            Console.WriteLine($"{nameof(OrderServices)} is Changing state");

            // notify observers
            Console.WriteLine($"{nameof(OrderServices)} is notifying observer ...");
            Notify(new TicketChange(artistID, amount));

        }
    }
}
