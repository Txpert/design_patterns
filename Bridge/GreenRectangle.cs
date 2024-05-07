using System;
using System.Runtime.InteropServices;

namespace Bridge
{
    public class GreenRectangle : IDrawAPI
    {
        public void Draw(int x, int y, int width, int height, [Optional] int length)
        {
            Console.WriteLine($"The green rectangle was drawn at position ({x},{y}), with width {width} and height {height}.");
        }
    }

}

