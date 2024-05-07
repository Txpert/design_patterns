using System;


namespace Bridge
{

    public class Triangle : Shape
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private int length;


        public Triangle(IDrawAPI drawAPI, int x, int y, int width, int height)
            : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.length = Convert.ToInt32(Math.Sqrt((width*width)+(height*height)));
        }

        // Overridden method from abstract class Shape; it calls the Draw method of the drawing API
        public override void Draw()
        {
            drawAPI.Draw(x, y, width, height, length);
        }




    }






}
