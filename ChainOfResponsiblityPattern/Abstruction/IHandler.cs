using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsiblityPattern.Abstruction
{

    public interface IHandler<T>where T : class
    {
        IHandler<T> SetSuccessor(IHandler<T> successor);
        void Handle(T request);
    }
}
