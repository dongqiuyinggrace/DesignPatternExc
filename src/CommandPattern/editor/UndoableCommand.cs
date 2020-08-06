
using DesignPatternExc.src.CommandPattern.editor;

namespace DesignPatternExc.src.CommandPattern
{
    public interface UndoableCommand : ICommand
    {
        void UnExecute();
    }
}