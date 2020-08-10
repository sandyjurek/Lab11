using System;

namespace Lab11
{
    public class Drama : IMovies
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public void MyMovieList()
        {
            Console.WriteLine("Chariots of Fire");
            Console.WriteLine("Good Witch");
            Console.WriteLine("Perry Mason");
            Console.WriteLine("Sherlock Holmes");
            Console.WriteLine("Men in Black");
            Console.WriteLine("Pebbles");
            Console.WriteLine("Horse Whisperer");
            Console.WriteLine("Lost in Translation");
            Console.WriteLine("Love, Actually");
            Console.WriteLine("Gone With the Wind");
        }
    }
}

