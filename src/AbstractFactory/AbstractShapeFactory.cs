namespace DesignPatternExc.src.AbstractFactory
{
    public abstract class AbstractShapeFactory
    {
        public abstract Shape GetShape(string type);
    }
}