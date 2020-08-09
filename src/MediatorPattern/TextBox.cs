namespace DesignPatternExc.src.MediatorPattern
{
    public class TextBox : UIControl
    {
        private string _content;

        public string Content
        {
            get { return _content; }
            set 
            { 
                _content = value; 
                NotifyObserver();
            }
        }
        
    }
}