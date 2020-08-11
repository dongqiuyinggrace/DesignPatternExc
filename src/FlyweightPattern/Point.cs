namespace DesignPatternExc.src.FlyweightPattern
{
    public class Point
    {
        private readonly int _x;
        private readonly int _y;
        private readonly PointIcon _icon;
        public Point(int x, int y, PointIcon icon)
        {
            _icon = icon;
            _y = y;
            _x = x;

        }

        public void Draw()
        {
            System.Console.WriteLine($"draw Icon: {_icon.Type} at X: {_x}, Y: {_y} ");
        }
    }
}