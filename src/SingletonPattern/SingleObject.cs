namespace DesignPatternExc.src.SingletonPattern
{
    public class SingleObject
    {
        private static SingleObject instance;
        private SingleObject() {}

        public static SingleObject GetInstance()
        {
            if (instance == null)
            {
                instance = new SingleObject();
            }

            return instance;
        }

        public void ShowMessage()
        {
            System.Console.WriteLine("Singleton Pattern");
        }
    }
}