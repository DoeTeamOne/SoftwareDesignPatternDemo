using StrategyPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Impementation
{
    public class Order
    {
        public string Customer { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public IExportService? ExportService { get; set; }
        public Order(string customer,int amount, string name, IExportService exportService) 
        {
            Customer = customer;
            Amount = amount;
            Name = name;
            ExportService = exportService;
        }
        public string Export()
        {
            return ExportService?.Export(this);
        }

    }
}
