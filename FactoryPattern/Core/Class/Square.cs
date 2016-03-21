using System;
using FactoryPattern.Core.Interface;

namespace FactoryPattern.Core.Class
{
    public class Square : IShape
    {
        public void Area()
        {
            Console.WriteLine("Square Area called");
        }
    }
}