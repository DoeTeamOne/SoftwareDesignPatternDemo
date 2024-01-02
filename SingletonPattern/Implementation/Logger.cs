using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Implementation
{
    /// <summary>
    /// our singleton class
    /// </summary>
    public class Logger
    {
        private static Logger _instance;

        public static Logger Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }
        protected Logger()
        {

        }
        public string Log(string message)
        {
            return message;
        }
    }
}
