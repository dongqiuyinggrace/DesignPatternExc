using System.Collections.Generic;

namespace DesignPatternExc.src.FlyweightPattern
{
    public class PointService
    {
        private readonly PointIconFactory _factory;
        public PointService(PointIconFactory factory)
        {
            _factory = factory;
        }
        private List<Point> points = new List<Point>();
        public List<Point> GetPoints()
        {
            var point = new Point(1, 2, _factory.GetPointIcon(PointType.CAFF));
            points.Add(point);
            return points;
        }
    }
}