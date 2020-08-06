namespace DesignPatternExc.src.CommandPattern.fx
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine("Resize command");
        }
    }
}