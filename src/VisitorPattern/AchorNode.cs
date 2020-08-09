namespace DesignPatternExc.src.VisitorPattern
{
    public class AchorNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}