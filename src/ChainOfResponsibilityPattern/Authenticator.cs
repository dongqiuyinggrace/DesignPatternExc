namespace DesignPatternExc.src.ChainOfResponsibilityPattern
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandling(HttpRequest request)
        {
            var isValid = false;
            if (request.Username == "Admin" && request.Password == "1234")
            {
                isValid = true;
                System.Console.WriteLine("Authenticator");
            }

            return !isValid;
        }
    }
}