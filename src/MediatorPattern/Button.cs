namespace DesignPatternExc.src.MediatorPattern
{
    public class Button : UIControl
    {
        private bool _isActive;
    
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;
                NotifyObserver();
            }
        }

    }
}