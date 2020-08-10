using DesignPatternExc.src.AdapterPattern.AvaFilters;

namespace DesignPatternExc.src.AdapterPattern
{
    public class CaramelFilter : IFilter
    {
        private readonly Caramel _caramel;
        public CaramelFilter(Caramel caramel)
        {
            _caramel = caramel;

        }
        public void Apply(Image image)
        {
            _caramel.Init();
            _caramel.Render(image);
        }
    }
}