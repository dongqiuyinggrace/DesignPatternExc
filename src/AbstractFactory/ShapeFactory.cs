namespace DesignPatternExc.src.AbstractFactory
{
    public class ShapeFactory : AbstractShapeFactory
    {
        public override Shape GetShape(string type)
        {
            if (type == "Rectangle")
            {
                return new Rectangle();
            } else if (type == "Square")
            {
                return new Square();
            }

            return null;
        }
    }
}