using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePattern.Abstruction;

namespace TemplatePattern.Implementation
{
    public class EudoraMailParser : MailParser
    {
        public override string FindServer()
        {
            return "finding eudora server through a custom algorithm...........";
        }
        public override string AuthenticateToServer()
        {
            return "Connecting Eudora ............";
        }
    }
}
