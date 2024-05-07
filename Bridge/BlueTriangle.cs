using System;
using System.Runtime.InteropServices;

namespace Bridge
{


    public class BlueTriangle : IDrawAPI
    {
        public void Draw(int x, int y, int width, int height)
        {
            Console.WriteLine($"The yellow rectangle was drawn at position ({x},{y}), with width {width} and height {height}.");
        }



    }



}
