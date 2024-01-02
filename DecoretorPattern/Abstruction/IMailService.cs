using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoretorPattern.Abstruction
{
    public interface IMailService
    {

        bool SendMail(string Message);
        string LogInfo();
    }
}
