using System;
using FactoryPattern.Core.Interface;

namespace FactoryPattern.Core.Class
{
    public class Circle : IShape
    {
        public void Area()
        {
            Console.WriteLine("Circle Area called");
        }
    }
}