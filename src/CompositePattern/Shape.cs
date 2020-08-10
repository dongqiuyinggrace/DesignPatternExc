namespace DesignPatternExc.src.CompositePattern
{
    public class Shape : IComponent
    {
        public void Move()
        {
            System.Console.WriteLine("Move Shape");
        }

        public void Render()
        {
            System.Console.WriteLine("Render Shape");
        }
    }
}