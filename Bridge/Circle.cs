using System;
namespace Bridge
{
    public class Circle : Shape
    {
        // Private member variables for the dimensions of the rectangle
        private int x;
        private int y;
        private int radius;

        // Constructor: Initializes a new rectangle specifying an API for drawing and dimensions
        public Circle(IDrawAPI drawAPI, int x, int y, int radius)
            : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        // Overridden method from abstract class Shape; it calls the Draw method of the drawing API
        public override void Draw()
        {
            drawAPI.Draw(x, y, radius);
        }
    }
}

