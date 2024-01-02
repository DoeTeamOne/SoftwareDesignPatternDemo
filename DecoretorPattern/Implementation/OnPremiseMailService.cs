using DecoretorPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoretorPattern.Implementation
{
    public class OnPremiseMailService : IMailService
    {
        string lognfo = "";

        public string LogInfo()
        {
            return lognfo;
        }

        public bool SendMail(string Message)
        {
            lognfo = $"{Message} sent from  On Prem Service ";
            return true;
        }
    }
}
