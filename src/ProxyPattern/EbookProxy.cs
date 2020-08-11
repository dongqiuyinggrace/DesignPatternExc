namespace DesignPatternExc.src.ProxyPattern
{
    public class EbookProxy : Ebook
    {
        private readonly string _fileName;
        private RealEbook _ebook;
        public EbookProxy(string fileName)
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
            _ebook.Show();
        }
    }
}