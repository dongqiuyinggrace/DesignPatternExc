using System.Collections.Generic;

namespace DesignPatternExc.src.FlyweightPattern
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();
        public PointIcon GetPointIcon(PointType type)
        {
            if (!icons.ContainsKey(type))
            {
                icons[type] = new PointIcon(type, null);
            }

            return icons[type];
        }
    }
}