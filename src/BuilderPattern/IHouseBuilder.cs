namespace DesignPatternExc.src.BuilderPattern
{
    public interface IHouseBuilder
    {  //any kind of house part building can be added
        void BuildWalls();
        void BuildDoors();
        void BuildRoof();
    }
}