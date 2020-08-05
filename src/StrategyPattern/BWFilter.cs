namespace DesignPatternExc.src.StrategyPattern
{
    public class BWFilter : Filter
    {
        public void Filter(string fileName)
        {
            System.Console.WriteLine("Do B&W filter");
        }
    }
}