namespace DesignPatternExc.src.VisitorPattern
{
    public class HighLightOperation : IOperation
    {
        public void Apply(HeadingNode node)
        {
            System.Console.WriteLine("HeadingNode--Highlight");
        }

        public void Apply(AchorNode node)
        {
            System.Console.WriteLine("AchorNode--Highlight");
        }
    }
}