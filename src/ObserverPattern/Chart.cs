namespace DesignPatternExc.src.ObserverPattern
{
    public class Chart : IObserver
    {
        private readonly DataSource _data;
        public Chart(DataSource data)
        {
            _data = data;

        }
        public void Update()
        {
            System.Console.WriteLine("Update Chart " + _data.Value);
        }
    }
}