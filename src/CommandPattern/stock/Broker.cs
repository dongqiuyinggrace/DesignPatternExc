using System.Collections.Generic;

namespace DesignPatternExc.src.CommandPattern.stock
{
    public class Broker
    {
        private List<IOrder> orders = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            orders.Add(order);
        }

        public void PlaceOrder()
        {
            foreach (var order in orders)
            {
                order.Execute();
            }
            orders.Clear();
        }
    }
}