namespace DesignPatternExc.src.StrategyPattern
{
    public class JpgCompressor : Compressor
    {
        public void Compress(string fileName)
        {
            System.Console.WriteLine("Compress with JPG");
        }
    }
}