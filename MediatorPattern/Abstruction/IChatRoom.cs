using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Abstruction
{
    public interface IChatRoom
    {
        void register(TeamMember teamMember);
        void Send(string from, string Message); // Group Chat
        void Send(string from, string to, string message); // specific Pesron chat
        void SendTo<T>(string from, string message) where T:TeamMember;  // send Message for specific Members in a group

    }
}
