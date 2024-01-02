using DecoretorPattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoretorPattern.Implementation
{
    public class CloudMailService : IMailService
    {
        string lognfo = "";
        public string LogInfo()
        {
            return lognfo;
        }

        public bool SendMail(string Message)
        {
            lognfo = $"{Message} sent from Cloud Mail Service";
            return true;
        }
    }
}
