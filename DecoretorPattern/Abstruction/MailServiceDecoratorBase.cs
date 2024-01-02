using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoretorPattern.Abstruction
{/// <summary>
/// Decorator Base Abstruction
/// </summary>
    public abstract class MailServiceDecoratorBase : IMailService
    {
        private readonly IMailService _mailservice;
        public string lognfo = "";
        public MailServiceDecoratorBase(IMailService service)
        {
            _mailservice = service;
        }

        public string LogInfo()
        {
            return lognfo;
        }

        public virtual bool SendMail(string Message)
        {
            return _mailservice.SendMail(Message);
        }
    }
}
