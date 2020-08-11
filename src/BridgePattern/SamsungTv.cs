namespace DesignPatternExc.src.BridgePattern
{
    public class SamsungTv : Device
    {
        public void SetChannel(int number)
        {
            System.Console.WriteLine($"Samsung: Set Channel {number}");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Samsung: Turn Off");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Samsung: Turn On");
        }
    }
}