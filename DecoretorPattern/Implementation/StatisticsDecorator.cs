using DecoretorPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoretorPattern.Implementation
{
public class StatisticsDecorator : MailServiceDecoratorBase
    {
        public StatisticsDecorator(IMailService mailService):base(mailService) 
        {

        }

        public override bool SendMail(string Message)
        {
           
            base.lognfo = $"Collecting Statstics in {nameof(StatisticsDecorator)}";
            return base.SendMail(Message);
        }

    }
}
