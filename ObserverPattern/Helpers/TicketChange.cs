using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Helpers
{
    public class TicketChange
    {
        public int Amount { get; set; }
        public int ArtistId { get; set; }
        public TicketChange(int amount, int artistId)
        {
            Amount = amount;
            ArtistId = artistId;
        }
    }
}
