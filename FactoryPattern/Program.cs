using System;
using FactoryPattern.Core.Class;

namespace FactoryPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var shape = ShapeFactory.GetShape("circle");
            shape.Area();

            shape = ShapeFactory.GetShape("rectangle");
            shape.Area();

            shape = ShapeFactory.GetShape("square");
            shape.Area();

            Console.ReadKey();
        }
    }
}