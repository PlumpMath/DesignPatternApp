using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyPattern.Core.Class;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new ProxyImage("demo.png");
            image.Display();

            image.Display();

            Console.ReadKey();
        }
    }
}
