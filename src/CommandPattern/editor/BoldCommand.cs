namespace DesignPatternExc.src.CommandPattern.editor
{
    public class BoldCommand : UndoableCommand
    {
        private string prevContent;
        private History _history;
        private HtmlDocument _document;
        public BoldCommand(History history, HtmlDocument document)
        {
            _history = history;
            _document = document;
        }
        public void Execute()
        {
            prevContent = _document.Content;
            _document.MakeBold();
            _history.push(this);
        }

        public void UnExecute()
        {
            _document.Content = prevContent;
        }
    }
}