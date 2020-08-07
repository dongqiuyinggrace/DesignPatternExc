namespace DesignPatternExc.src.ObserverPattern
{
    public class SpreadSheet : IObserver
    {
        private readonly DataSource _data;
        public SpreadSheet(DataSource data)
        {
            _data = data;
        }
        public void Update()
        {
            System.Console.WriteLine("Update Spread Sheet " + _data.Value);
        }
    }
}