namespace DesignPatternExc.src.FlyweightPattern
{
    public class PointIcon
    {
        private readonly PointType _type;
        
        private readonly byte[] _icon;
        public PointIcon(PointType type, byte[] icon)
        {
            _icon = icon;
            _type = type;
        }

        public PointType Type
        {
            get { return _type; }
        }
        

    }
}