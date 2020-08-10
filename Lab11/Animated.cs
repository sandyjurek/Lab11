using System;

namespace Lab11
{
    public class Animated : IMovies
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public void MyMovieList()
        {
            Console.WriteLine("Frozen");
            Console.WriteLine("Mulan");
            Console.WriteLine("Up");
            Console.WriteLine("Mickey's Christmas");
            Console.WriteLine("Spirited Away");
            Console.WriteLine("Bambi");
            Console.WriteLine("Rio");
            Console.WriteLine("Madagascar");
            Console.WriteLine("Snow White");
            Console.WriteLine("Cinderella");
        }
    }
}

