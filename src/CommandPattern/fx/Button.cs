namespace DesignPatternExc.src.CommandPattern.fx
{
    public class Button
    {
        private string label;
        private ICommand command;
        public Button(ICommand command)
        {
            this.command = command;
        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        public void click()
        {
            command.Execute();
        }
        
    }
}