namespace DesignPatternExc.src.CommandPattern.stock
{
    public class Stock
    {
        private readonly string _name;
        public Stock(string name)
        {
            _name = name;
        }
        private int quantity = 10;
        public void buy()
        {
            System.Console.WriteLine("Stock: " + _name + " Quantity: " + quantity + " is bought");
        }

        public void sell()
        {
            System.Console.WriteLine("Stock: " + _name + " Quantity: " + quantity + " is sold");
        }
    }
}