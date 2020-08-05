namespace DesignPatternExc.src.StatePattern
{
    public class EraserTool : Tool
    {
        public void MouseDown()
        {
            System.Console.WriteLine("Erase Icon");
        }

        public void MouseUp()
        {
            System.Console.WriteLine("Erase something");
        }
    }
}