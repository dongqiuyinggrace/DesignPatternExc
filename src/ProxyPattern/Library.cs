using System.Collections.Generic;

namespace DesignPatternExc.src.ProxyPattern
{
    public class Library
    {
        private Dictionary<string, Ebook> books = new Dictionary<string, Ebook>();

        public void Add(Ebook book)
        {
            books[book.GetFileName()] = book;
        }

        public void OpenEbook(string fileName)
        {
            books[fileName].Show();
        }
    }
}