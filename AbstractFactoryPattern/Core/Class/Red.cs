using System;
using AbstractFactoryPattern.Core.Interface;

namespace AbstractFactoryPattern.Core.Class
{
    public class Red:IColor
    {
        public void DrawColor()
        {
            Console.WriteLine("Red is drawn.");
        }
    }
}