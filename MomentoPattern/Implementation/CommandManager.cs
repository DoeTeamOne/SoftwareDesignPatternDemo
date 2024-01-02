using MomentoPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentoPattern.Implementation
{
    public class CommandManager
    {
        private readonly Stack<AddEmployeeToManagerListMomento> _momentos = new Stack<AddEmployeeToManagerListMomento>();
        private AddEmployeeToManagerList? _command;
        public void Invoke(ICommand command)
        {
            if (_command == null)
            {
                _command = (AddEmployeeToManagerList)command;
            }
            if (command.CanExcute())
            {
                command.Execute();
                _momentos.Push(((AddEmployeeToManagerList)command).CreateMomento());
            }
        }
        public void Undo()
        {
            if (_momentos.Any())
            {
                _command?.RestoreMomento(_momentos.Pop());
                _command.Undo();
            }
          
        }
    }
}
