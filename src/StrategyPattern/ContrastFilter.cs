namespace DesignPatternExc.src.StrategyPattern
{
    public class ContrastFilter : Filter
    {
        public void Filter(string fileName)
        {
            System.Console.WriteLine("Do Contrast filter");
        }
    }
}