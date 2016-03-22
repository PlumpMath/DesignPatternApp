using System;
using AbstractFactoryPattern.Core.Interface;

namespace AbstractFactoryPattern.Core.Class
{
    public class Green:IColor
    {
        public void DrawColor()
        {
            Console.WriteLine("Green is drawn.");
        }
    }
}