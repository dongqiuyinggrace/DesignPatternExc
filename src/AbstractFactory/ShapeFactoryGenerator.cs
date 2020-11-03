namespace DesignPatternExc.src.AbstractFactory
{
    public class ShapeFactoryGenerator
    {
        public static AbstractShapeFactory GetFactory(bool rounded) 
        {
            if (rounded)
            {
                return new RoundedShapeFactory();
            }
            else 
            {
                return new ShapeFactory();
            }
        }
    }
}