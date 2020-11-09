namespace DesignPatternExc.src.BuilderPattern
{
    public class ModernHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void BuildDoors()
        {
            _house.Add("Stylish door");
        }

        public void BuildRoof()
        {
            _house.Add("Fancy roof");
        }

        public void BuildWalls()
        {
            _house.Add("wall with painting");
        }

        public void GetHouse()
        {
            _house.Show();
        }
    }
}