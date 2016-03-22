using System;
using AbstractFactoryPattern.Core.Interface;

namespace AbstractFactoryPattern.Core.Class
{
    public class Rectangle:IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("Rectangle is Drawn.");
        }
    }
}