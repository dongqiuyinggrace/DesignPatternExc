namespace DesignPatternExc.src.BuilderPattern
{
    public class CottageBuilder : IHouseBuilder
    {  //decide how to implement each part of building
        private House _house = new House();   //can be a house or object of other kind which has similar steps as building a house

        public void BuildDoors()
        {
            _house.Add("Wood doors");
        }

        public void BuildRoof()
        {
            _house.Add("Hay roof");
        }

        public void BuildWalls()
        {
            _house.Add("Mud walls");
        }

        public void GetHouse()
        {
            _house.Show();
        }
    }
}