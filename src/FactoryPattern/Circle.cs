using System;

namespace DesignPatternExc.src.FactoryPattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Draw a circle");
        }
    }
}