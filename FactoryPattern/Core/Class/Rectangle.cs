using System;
using FactoryPattern.Core.Interface;

namespace FactoryPattern.Core.Class
{
    public class Rectangle : IShape
    {
        public void Area()
        {
            Console.WriteLine("Rectangle Area called");
        }
    }
}