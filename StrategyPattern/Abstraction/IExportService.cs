using StrategyPattern.Impementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Abstraction
{
    public interface IExportService
    {
        string Export(Order order);
    }
}
