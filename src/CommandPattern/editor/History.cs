using System.Collections.Generic;

namespace DesignPatternExc.src.CommandPattern.editor
{
    public class History
    {
        private List<UndoableCommand> commands = new List<UndoableCommand>();
        public int Size
        {
            get { return commands.Count; }
        }
        

        public void push(UndoableCommand command)
        {
            commands.Add(command);
        }

        public UndoableCommand Pop()
        {
            var lastItem = commands[commands.Count - 1];
            commands.Remove(lastItem);
            return lastItem;
        }
        
    }
}