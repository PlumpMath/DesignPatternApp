using FactoryPattern.Core.Interface;

namespace FactoryPattern.Core.Class
{
    public class ShapeFactory
    {
        public static IShape GetShape(string shapeType)
        {
            switch (shapeType.ToLower())
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectangle();
                case "square":
                    return new Square();
                default:
                    return null;
            }
        }
    }
}