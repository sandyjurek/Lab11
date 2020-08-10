using System;

namespace Lab11
{
    public class Horror : IMovies
    {

        public string Title { get; set; }
        public string Category { get; set; }

        public void MyMovieList()
        {
            Console.WriteLine("Nightmare");
            Console.WriteLine("Halloween");
            Console.WriteLine("Freddy");
            Console.WriteLine("Devil");
            Console.WriteLine("Witch");
            Console.WriteLine("Scarefest");
            Console.WriteLine("Murder");
            Console.WriteLine("Scary");
            Console.WriteLine("Boring");
            Console.WriteLine("Zombies");
        }
    }
}
