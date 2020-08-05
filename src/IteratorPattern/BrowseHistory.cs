using System.Collections.Generic;

namespace DesignPatternExc.src.IteratorPattern
{
    public class BrowseHistory
    {
        private List<string> urls = new List<string>();

        public void push(string url)
        {
            urls.Add(url);
        }

        public string pop()
        {
            var lastItem = urls[urls.Count - 1];
            urls.Remove(lastItem);
            return lastItem;
        }

        public Iterator createIterator()
        {
            return new ListIterator(this);
        }

        public class ListIterator : Iterator
        {
            private readonly BrowseHistory _history;
            private int index;
            public ListIterator(BrowseHistory history)
            {
                _history = history;
            }
            public string current()
            {
                return _history.urls[index];
            }

            public bool hasNext()
            {
                return (index < _history.urls.Count);
            }

            public void next()
            {
                index++;
            }
        }

    }
}