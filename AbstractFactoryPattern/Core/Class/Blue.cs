using System;
using AbstractFactoryPattern.Core.Interface;

namespace AbstractFactoryPattern.Core.Class
{
    public class Blue:IColor
    {
        public void DrawColor()
        {
            Console.WriteLine("Blue is drawn.");
        }
    }
}