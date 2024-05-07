namespace Composite;

class Program
{
    static void Main(string[] args)
    {
        {
            // Create a new directory for the course
            Directory designpatterns = new Directory("training");

            // Create a new file for the course content and add it to the design patterns directory
            File content = new File("content", "Timo");
            designpatterns.Add(content);

            // Create a new directory to store video files
            Directory videos = new Directory("videos");

            // Add the videos directory to the video course directory
            designpatterns.Add(videos);

            // Create video files and add them to the videos directory
            File video1 = new File("video1", "Timo");
            File video2 = new File("video2", "Timo");
            videos.Add(video1);
            videos.Add(video2);

            //Create a new directory
            Directory comedy = new Directory("comedy");

            videos.Add(comedy);

            File comedy1 = new File("comedy1", "Kristina");
            File comedy2 = new File("comedy2", "Kristina");
            File comedy3 = new File("comedy3", "Kristina");

            comedy.Add(comedy1);
            comedy.Add(comedy2);
            comedy.Add(comedy3);

            // Print the contents of the video course directory
            designpatterns.Print();

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}

