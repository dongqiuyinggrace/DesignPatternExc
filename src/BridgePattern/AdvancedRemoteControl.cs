namespace DesignPatternExc.src.BridgePattern
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(Device device) : base(device)
        {
        }

        public void SetChannel(int number)
        {
            _device.SetChannel(number);
        }
       
    }
}