namespace DesignPatternExc.src.AdapterPattern
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            System.Console.WriteLine("Vivid Filter");
        }
    }
}