namespace DesignPatternExc.src.ProxyPattern
{
    public class EbookLoggingProxy : Ebook
    {
        private readonly string _fileName;
        private RealEbook _ebook;
        public EbookLoggingProxy(string fileName)
        {
            _fileName = fileName;

        }
        public string GetFileName()
        {
            return _fileName;
        }

        public void Show()
        {
            if (_ebook == null)
            {
                _ebook = new RealEbook(_fileName);
            }
            System.Console.WriteLine("Logging");
            _ebook.Show();
            
        }
    }
}