using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemos
{
    class EditorState
    {
        private string _content;
        private string _title;

        public EditorState(string content, string title)
        {
            _content = content;
            _title = title;
        }

        public string Content
        {
            get { return _content; }
        }
        public string Title
        {
            get { return _title; }
        }

    }
}
