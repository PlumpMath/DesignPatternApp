using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SingletonPattern.Core;

namespace SingletonPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var log = Logger.GetInstance();
            log.LogMessage("First attempt error");
            Thread.Sleep(new TimeSpan(0, 0, 10));
            log.LogMessage("First attempt error");
            Thread.Sleep(new TimeSpan(0, 0, 10));
            log.LogMessage("First attempt error");

            Console.ReadKey();
        }
    }
}
