using System;
using AbstractFactoryPattern.Core.Interface;

namespace AbstractFactoryPattern.Core.Class
{
    public class Square :IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("Square is drawn.");
        }
    }
}