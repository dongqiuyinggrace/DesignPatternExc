namespace DesignPatternExc.src.VisitorPattern
{
    public class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}