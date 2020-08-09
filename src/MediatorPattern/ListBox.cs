using System;

namespace DesignPatternExc.src.MediatorPattern
{
    public class ListBox : UIControl
    {
        private string _selection;
        public string Selection
        {
            get { return _selection; }
            set 
            { 
                _selection = value; 
                NotifyObserver();
            }
        }
    }
}