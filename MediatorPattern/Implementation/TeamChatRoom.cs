using MediatorPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Implementation
{
    /// <summary>
    /// concerete Mediator
    /// </summary>
    public class TeamChatRoom : IChatRoom
    {
        private readonly Dictionary<string, TeamMember> _teamMembers = new Dictionary<string, TeamMember>() ;
        public void register(TeamMember teamMember)
        {
            teamMember.SetChatRoom(this);
            if (!_teamMembers.ContainsKey(teamMember.Name))
            {
                _teamMembers.Add(teamMember.Name, teamMember);
            }
        }

        public void Send(string from, string Message)
        {
            foreach (var member in _teamMembers.Values)
            {
               member.Receive(from, Message);
            }
        }

        public void Send(string from, string to, string message)
        {
            var TeamMember = _teamMembers[to];
            TeamMember?.Receive(from, message);
        }

        public void SendTo<T>(string from, string message) where T : TeamMember
        {
            foreach(var member in _teamMembers.Values.OfType<T>())
            {
                member.Receive(from, message);
            }
        }
    }
}
