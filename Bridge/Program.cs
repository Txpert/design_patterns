namespace Bridge;

class Program
{
    static void Main(string[] args)
    {
        // Creating a rectangle object using a 'GreenRectangle' drawing method.
        Shape greenRectangle = new Rectangle(new GreenRectangle(), 100, 200, 32, 32);

        // Drawing the rectangle.
        greenRectangle.Draw();

        // Prevents the console window from closing immediately.

        Shape yellowRectangle = new Rectangle(new YellowRectangle(), 20, 35, 50, 50);
        yellowRectangle.Draw();


        Console.ReadKey();
    }
}
