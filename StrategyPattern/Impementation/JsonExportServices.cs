using StrategyPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Impementation
{
    public class JsonExportServices : IExportService
    {
        public string Export(Order order)
        {
            return $"Exporting {order.Name} to Json";
        }
    }
}
