using DesignPatternExc.src.AdapterPattern.AvaFilters;

namespace DesignPatternExc.src.AdapterPattern
{
    public class CaramelAdapter : Caramel, IFilter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}