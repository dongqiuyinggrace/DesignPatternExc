namespace DesignPatternExc.src.IteratorPattern
{
    public interface Iterator
    {
        bool hasNext();
        string current();
        void next();
    }
}