namespace DesignPatternExc.src.ChainOfResponsibilityPattern
{
    public class HttpRequest
    {
        public HttpRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}