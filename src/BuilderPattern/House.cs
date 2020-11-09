using System.Collections.Generic;

namespace DesignPatternExc.src.BuilderPattern
{
    public class House
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            foreach (var part in _parts)
            {
                System.Console.WriteLine(part);
            }
        }
    }
}