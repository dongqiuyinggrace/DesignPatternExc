namespace DesignPatternExc.src.ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        private Handler next;
        public Handler(Handler next)
        {
            this.next = next;
        }
        public void Handle(HttpRequest request)
        {
            if (DoHandling(request))
                return;
            if (next != null)
                next.Handle(request);
        }

        public abstract bool DoHandling(HttpRequest request);

    }
}