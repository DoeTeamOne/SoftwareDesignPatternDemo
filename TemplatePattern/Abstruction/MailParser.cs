using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Abstruction
{
    public abstract class MailParser
    {
        public virtual string FindServer()
        {
            //sub class overide this if needed
            return "";
        }
        public abstract string AuthenticateToServer();  // we make this abstruct because the implemetation is provided by subclass

        public string ParseHtmlMailBody(string identifier)
        {
            return $" this is the body from mail withe id {identifier}.........";
        }

        /// <summary>
        /// this is Template method
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public string ParseMailBody(string identifier)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("parsing mail body (in Template Method).........");
           var serverResult = FindServer();
            var authResult =AuthenticateToServer() ;
            var ParseResult = ParseHtmlMailBody(identifier);
            sb.Append( serverResult);
            sb.Append(authResult);
            sb.Append( ParseResult );
            return sb.ToString();
        }
        
    }
}
