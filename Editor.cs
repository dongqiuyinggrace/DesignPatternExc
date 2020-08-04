using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemos
{
    class Editor
    {
        private string _content;
        private string _title;

        public string Title
        {
            get { return _title; }
            set 
            { 
                _title = value;
                Console.WriteLine("Title: " + _title);
            }
        }


        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
              Console.WriteLine("Content: " + _content);
            }
        }

        public EditorState createMemento()
        {
            return new EditorState(_content, _title);
        }

        public void restore(EditorState state)
        {
            Console.WriteLine("Restoring state");
            Content = state.Content;
            Title = state.Title;
        }

    }
}
