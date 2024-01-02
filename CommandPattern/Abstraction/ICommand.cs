using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Abstraction
{
    public  interface ICommand
    {
        void Execute();
        bool CanExcute();
        void Undo();    
    }
}
