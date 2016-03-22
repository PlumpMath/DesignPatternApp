using System;
using AbstractFactoryPattern.Core.Interface;

namespace AbstractFactoryPattern.Core.Class
{
    public class Circle:IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("Circle is drawn.");
        }
    }
}