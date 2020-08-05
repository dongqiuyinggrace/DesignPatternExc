using System;
using DesignPatternExc.src.StatePattern;

namespace DesignPatternExc
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.setCurrentTool(new EraserTool());
            canvas.MouseDown();
            canvas.MouseUp();

        }
    }
}
