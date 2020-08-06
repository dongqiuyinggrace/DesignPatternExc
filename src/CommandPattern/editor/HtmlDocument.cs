namespace DesignPatternExc.src.CommandPattern.editor
{
    public class HtmlDocument
    {
        public HtmlDocument(string content)
        {
            Content = content;
        }
        private string _content;
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public void MakeBold()
        {
            Content = "<b>" + Content + "</b>";
        }
        
    }
}