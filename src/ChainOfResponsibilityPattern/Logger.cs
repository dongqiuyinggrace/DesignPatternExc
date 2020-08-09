namespace DesignPatternExc.src.ChainOfResponsibilityPattern
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool DoHandling(HttpRequest request)
        {
            System.Console.WriteLine("Logger");
            return false;
        }
    }
}