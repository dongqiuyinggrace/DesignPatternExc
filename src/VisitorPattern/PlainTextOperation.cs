namespace DesignPatternExc.src.VisitorPattern
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            System.Console.WriteLine("HeadingNode--PlainText");
        }

        public void Apply(AchorNode node)
        {
            System.Console.WriteLine("AchorNode--PlainText");
        }
    }
}