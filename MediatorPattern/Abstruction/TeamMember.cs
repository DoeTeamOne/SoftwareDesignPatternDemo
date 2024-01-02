using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Abstruction
{
    public abstract class TeamMember
    {
        private IChatRoom? _chatRoom;
        public string Name { get; set; }
        public TeamMember(string name)
        {

            Name = name;
        }
        internal void SetChatRoom(IChatRoom chatRoom)
        {
            _chatRoom = chatRoom;
        }
        public void Send(string Message)
        {
             _chatRoom?.Send(Name, Message); // Send a message to the chatroom
        }

        public void Send(string to,string message)
        {
            _chatRoom?.Send(Name,to,message); // send a message to specific Person
        }

        public void Send<T>(string message)where T : TeamMember
        {
            _chatRoom?.SendTo<T>(Name, message);
        }
        public virtual void Receive(string from, string Message)
        {
            Console.WriteLine( $"Message from {from}  to {Name} : {Message}");
        }

    }
}
