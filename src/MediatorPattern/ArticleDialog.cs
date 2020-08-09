
namespace DesignPatternExc.src.MediatorPattern
{
    public class ArticleDialog
    {
        private Button saveButton = new Button();
        private TextBox titleTextBox = new TextBox();
        private ListBox articleListBox = new ListBox();

        public ArticleDialog()
        {
            articleListBox.AddObserver(new ArticleSelectedHandler(saveButton, titleTextBox, articleListBox));
            titleTextBox.AddObserver(new TitleChangedHandler(saveButton, titleTextBox, articleListBox));
        }

        public void SimulateChanges()
        {
            articleListBox.Selection = "Article1";
            System.Console.WriteLine("titleTextBox: " + titleTextBox.Content + ", " + "saveButton: " + saveButton.IsActive);
            titleTextBox.Content = "";
            System.Console.WriteLine("titleTextBox: " + titleTextBox.Content + ", " + "saveButton: " + saveButton.IsActive);

            titleTextBox.Content = "Article2";
            System.Console.WriteLine("titleTextBox: " + titleTextBox.Content + ", " + "saveButton: " + saveButton.IsActive);
        }

        class ArticleSelectedHandler : IObserver
        {
            private Button saveButton;
            private TextBox titleTextBox;
            private ListBox articleListBox;
            public ArticleSelectedHandler(Button saveButton, TextBox titleTextBox, ListBox articleListBox)
            {
                this.saveButton = saveButton;
                this.titleTextBox = titleTextBox;
                this.articleListBox = articleListBox;
            }
            public void Update()
            {
                titleTextBox.Content = articleListBox.Selection;
                saveButton.IsActive = true;
            }
        }

        class TitleChangedHandler : IObserver
        {
            private Button saveButton;
            private TextBox titleTextBox;
            private ListBox articleListBox;
            public TitleChangedHandler(Button saveButton, TextBox titleTextBox, ListBox articleListBox)
            {
                this.saveButton = saveButton;
                this.titleTextBox = titleTextBox;
                this.articleListBox = articleListBox;
            }
            public void Update()
            {
                var content = titleTextBox.Content;
                var isEmpty = (content == null || content.Length == 0);
                saveButton.IsActive = !isEmpty;
            }
        }
    }
}