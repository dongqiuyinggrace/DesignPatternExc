using System;
using System.Collections.Generic;

namespace DesignPatternExc
{
    class History
    {
        private List<EditorState> states = new List<EditorState>();

        public void push(EditorState memento)
        {
            states.Add(memento);
        }

        public EditorState pop()
        {
            var lastItem = states[states.Count - 1];
            states.Remove(lastItem);

            return lastItem;

        }

    }
}
