namespace DesignPatternExc.src.VisitorPattern
{
    public interface IOperation
    {
        void Apply(HeadingNode node);
        void Apply(AchorNode node);
    }
}