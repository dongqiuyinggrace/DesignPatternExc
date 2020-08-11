namespace DesignPatternExc.src.BridgePattern
{
    public interface Device
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }
}