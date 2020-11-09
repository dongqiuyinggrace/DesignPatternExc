namespace DesignPatternExc.src.BuilderPattern
{
    public class Director
    {
        public void BuildHouse(IHouseBuilder builder) 
        {
            builder.BuildWalls();
            builder.BuildRoof();
            builder.BuildDoors();
            //more or less building steps can be added, and the step order can be changed as well
        }
    }
}