namespace DesignPatternExc.src.ProxyPattern
{
    public class RealEbook : Ebook
    {
        private readonly string _fileName;
        public RealEbook(string fileName)
        {
            _fileName = fileName;
            Load();
        }

        private void Load()
        {
            System.Console.WriteLine("Loding book: " + _fileName);
        }

        public void Show()
        {
            System.Console.WriteLine("Show book: " + _fileName);
        }

        public string GetFileName()
        {
            return _fileName;
        }
        
    }
}