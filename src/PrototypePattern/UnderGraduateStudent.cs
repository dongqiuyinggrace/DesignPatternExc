namespace DesignPatternExc.src.PrototypePattern
{
    public class UnderGraduateStudent : IStudent
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string SchoolName { get; set; }
        public IStudent Clone()
        {
            return (IStudent)MemberwiseClone();
        }

        public void ShowMessage()
        {
            System.Console.WriteLine("Under graduate student");
        }
    }
}