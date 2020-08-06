namespace DesignPatternExc.src.CommandPattern.fx
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _service;
        public AddCustomerCommand(CustomerService service)
        {
            _service = service;

        }
        public void Execute()
        {
            _service.AddCustomer();
        }
    }
}