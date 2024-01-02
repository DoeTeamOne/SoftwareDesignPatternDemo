using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePattern.Abstruction;

namespace TemplatePattern.Implementation
{
    public class ExchangeMailParser : MailParser
    {
        public override string AuthenticateToServer()
        {
         return  "connecting Exchange Mail Parser......................";
        }
    }
}
