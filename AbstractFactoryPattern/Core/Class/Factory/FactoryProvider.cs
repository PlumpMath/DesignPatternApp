namespace AbstractFactoryPattern.Core.Class.Factory
{
    public class FactoryProvider
    {
        public static AbstractFactory GetFactory(string factoryType)
        {
            switch (factoryType.ToLower())
            {
                case "shape":
                    return new ShapeFactory();
                case "color":
                    return new ColorFactory();
            }

            return null;
        }
    }
}