namespace DesignPatternExc.src.AbstractFactory
{
    public class RoundedShapeFactory : AbstractShapeFactory
    {
        public override Shape GetShape(string type)
        {
            if (type == "Rectangle")
            {
                return new RoundedRectangle();
            } else if (type == "Square")
            {
                return new RoundedSquare();
            }
            
            return null;
        }
    }
}