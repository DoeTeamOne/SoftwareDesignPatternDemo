using DecoretorPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoretorPattern.Implementation
{
    public class MessageDataBaseDecorator:MailServiceDecoratorBase
    {
        public List<string> sentMessages { get; private set; } = new List<string>();
        public MessageDataBaseDecorator(IMailService mailservice):base(mailservice) 
        {

        }

        public override bool SendMail(string Message)
        {
            if (base.SendMail(Message))
            {
                sentMessages.Add(Message);
                return true;
            }
            return false;
        }
    }
}
