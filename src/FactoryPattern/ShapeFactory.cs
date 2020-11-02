namespace DesignPatternExc.src.FactoryPattern
{
    public class ShapeFactory
    {
        public IShape CreateShape(string type)
        {
            if (type == null)
            {
                return null;
            }

            if (type == "Circle")
            {
                return new Circle();
            }
            else if (type == "Rectangle")
            {
                return new Rectangle();
            }
            else if (type == "Square")
            {
                return new Square();
            }
            else {
                return null;
            }
        }
    }
}