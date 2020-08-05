namespace DesignPatternExc.src.StrategyPattern
{
    public class PngCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            System.Console.WriteLine("Compress with PNG");
        }
    }
}