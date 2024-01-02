using ObserverPattern.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Abstruction
{
    public abstract class TicketChangeNotifier
    {
        private  List<ITicketChangeListner>  _observers = new List<ITicketChangeListner>();
        public void AddObserver(ITicketChangeListner observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(ITicketChangeListner observer)
        {
            _observers.Remove(observer);
        }

        public void ClearObservers(TicketChange ticketChange)
        {
            foreach(var observer in _observers)
            {
                observer.ReceiveTicketChangeNotification(ticketChange);
            }

        }
        public void Notify(TicketChange ticketChange)
        {
            foreach (var observer in _observers)
            {
                observer.ReceiveTicketChangeNotification(ticketChange);
            }
        }
    }
}
