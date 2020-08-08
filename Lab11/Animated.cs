using System;

namespace Lab11
{
    public class Animated : IMovies
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public void VroomVroom()
        {
            Console.WriteLine("Frozen");
            Console.WriteLine("Mulan");
            Console.WriteLine("Up");
            Console.WriteLine("Mickey's Christmas");
            Console.WriteLine("Spirited");
            Console.WriteLine("Ducky");
            Console.WriteLine("Wucky");
            Console.WriteLine("Mucky");
            Console.WriteLine("SnowWhite");
            Console.WriteLine("Cinderella");
        }
    }
}

