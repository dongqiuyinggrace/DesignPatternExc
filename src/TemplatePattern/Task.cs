namespace DesignPatternExc.src.TemplatePattern
{
    public abstract class Task
    {
        private AuditTrail _audiTrail;

        public Task()
        {
            _audiTrail = new AuditTrail();
        }
        public Task(AuditTrail audiTrail)
        {
            _audiTrail = audiTrail;
        }

        public void Execute()
        {
            _audiTrail.Report();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}