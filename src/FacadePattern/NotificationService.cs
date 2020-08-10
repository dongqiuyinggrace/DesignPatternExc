namespace DesignPatternExc.src.FacadePattern
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connect = server.Connect("ip");
            var token = server.Authenticate("AppId", "Key");
            server.Send(token, new Message(message), "target");
            connect.DisConnect();
        }
    }
}