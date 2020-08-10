namespace DesignPatternExc.src.FacadePattern
{
    public class NotificationServer
    {
        public Connect Connect(string ipAddress)
        {
            return new Connect(ipAddress);
        }

        public AuthToken Authenticate(string AppId, string Key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken token, Message message, string target)
        {
            System.Console.WriteLine("Send a message");
        }
    }
}