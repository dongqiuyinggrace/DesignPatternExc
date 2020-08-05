namespace DesignPatternExc.src.StrategyPattern
{
    public class ImageStorage
    {
        // private readonly Compressor _compressor;
        // private readonly Filter _filter;
        // public ImageStorage(Compressor compressor, Filter filter)
        // {
        //     _filter = filter;
        //     _compressor = compressor;

        // }

        public void Store(string fileName, Compressor compressor, Filter filter)
        {
            compressor.Compress(fileName);
            filter.Filter(fileName);
        }
    }
}