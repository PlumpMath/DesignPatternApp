using AbstractFactoryPattern.Core.Interface;

namespace AbstractFactoryPattern.Core.Class.Factory
{
    public class ColorFactory : AbstractFactory
    {
        public override IShape GetShape(string shape)
        {
            return null;
        }

        public override IColor GetColor(string color)
        {
            switch (color.ToLower())
            {
                case "red":
                    return new Red();
                case "green":
                    return new Green();
                case "blue":
                    return new Blue();
            }

            return null;
        }
    }
}