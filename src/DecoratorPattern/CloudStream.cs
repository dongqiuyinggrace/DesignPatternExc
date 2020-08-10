namespace DesignPatternExc.src.DecoratorPattern
{
    public class CloudStream : IStream
    {
        public void Write(string data)
        {
            System.Console.WriteLine("Storing: " + data);
        }
    }
}