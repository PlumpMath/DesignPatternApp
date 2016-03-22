using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Core.Class.Factory;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = FactoryProvider.GetFactory("shape");
            var shape = factory.GetShape("circle");
            shape.DrawShape();

            shape = factory.GetShape("square");
            shape.DrawShape();

            factory = FactoryProvider.GetFactory("color");
            var color = factory.GetColor("red");
            color.DrawColor();

            color = factory.GetColor("blue");
            color.DrawColor();

            Console.ReadKey();
        }
    }
}
