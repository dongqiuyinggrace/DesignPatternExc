namespace DesignPatternExc.src.VisitorPattern
{
    public interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}