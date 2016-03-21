using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Core
{
    public class Logger
    {
        private  static Logger _logger;

        private Logger(){}

        public static Logger GetInstance()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }

            return _logger;
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("Log message is {0} @ {1}", message, DateTime.Now);
        }
    }
}
