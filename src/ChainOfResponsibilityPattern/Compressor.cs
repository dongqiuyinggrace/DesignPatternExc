namespace DesignPatternExc.src.ChainOfResponsibilityPattern
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public override bool DoHandling(HttpRequest request)
        {
            System.Console.WriteLine("Compressor");
            return false;
        }

    
    }
}