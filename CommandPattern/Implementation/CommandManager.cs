using CommandPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ICommand = CommandPattern.Abstraction.ICommand;

namespace CommandPattern.Implementation
{
    public  class CommandManager
    {
        private readonly Stack<ICommand> _commands = new Stack<ICommand>();
        public  void Invoke(ICommand command)
        {
            if (command.CanExcute())
            {
                command.Execute();
                _commands.Push(command);
            }
        }
        public void Undo()
        {
            _commands.Pop().Undo();
        }
    }
}
