namespace DesignPatternExc.src.CommandPattern.fx
{
    public class BalckAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            System.Console.WriteLine("Black and White Command");
        }
    }
}