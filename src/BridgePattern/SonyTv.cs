namespace DesignPatternExc.src.BridgePattern
{
    public class SonyTv : Device
    {
        public void SetChannel(int number)
        {
            System.Console.WriteLine($"Sony: Set Channel {number}");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Sony: Turn on");
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Sony: Turn Off");
        }
    }
}