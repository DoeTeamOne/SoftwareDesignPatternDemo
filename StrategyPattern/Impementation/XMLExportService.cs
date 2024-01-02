using StrategyPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Impementation
{
    public class XMLExportService : IExportService
    {
        public string Export(Order order)
        {
            return $"Ecporting {order.Name} to XML";
        }
    }
}
