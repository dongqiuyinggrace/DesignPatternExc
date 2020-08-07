namespace DesignPatternExc.src.CommandPattern.stock
{
    public class BuyStock : IOrder
    {
        private readonly Stock _stock;
        public BuyStock(Stock stock)
        {
            _stock = stock;

        }
        public void Execute()
        {
            _stock.buy();
        }
    }
}