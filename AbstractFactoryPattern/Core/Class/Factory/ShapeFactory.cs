using AbstractFactoryPattern.Core.Interface;

namespace AbstractFactoryPattern.Core.Class.Factory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shape)
        {
            switch (shape.ToLower())
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectangle();
                case "square":
                    return new Square();
            }

            return null;
        }

        public override IColor GetColor(string color)
        {
            return null;
        }
    }
}