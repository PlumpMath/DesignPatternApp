using AbstractFactoryPattern.Core.Interface;

namespace AbstractFactoryPattern.Core.Class.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shape);
        public abstract IColor GetColor(string color);
    }
}