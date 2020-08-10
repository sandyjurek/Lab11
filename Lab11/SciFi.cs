using System;

namespace Lab11
{
    public class SciFi : IMovies
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public void MyMovieList()
        {
            Console.WriteLine("Spaceballs");
            Console.WriteLine("Source Code");
            Console.WriteLine("Apollo 13");
            Console.WriteLine("Transformers");
            Console.WriteLine("Guardians of the Galaxy");
            Console.WriteLine("2001 Space Odyssey");
            Console.WriteLine("Star Wars");
            Console.WriteLine("Star Trek");
            Console.WriteLine("Battlestar Gallactica");
            Console.WriteLine("Edge of Tomorrow");
        }
    }
}
