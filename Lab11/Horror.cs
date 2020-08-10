using System;
using System.Collections.Generic;

namespace Lab11
{
    public class Horror : IMovies
    {

        public string Title { get; set; }
        public string Category { get; set; }

        public void MyMovieList()
        {
            Console.WriteLine("Nightmare on Elm Street");
            Console.WriteLine("Halloween");
            Console.WriteLine("Nightmare Before Christmas");
            Console.WriteLine("Devil in a Blue Dress");
            Console.WriteLine("Witchfest");
            Console.WriteLine("Scary Movie");
            Console.WriteLine("Ammityville Horror");
            Console.WriteLine("Friday the 13th");
            Console.WriteLine("Aliens are Attacking");
            Console.WriteLine("Zombies are Coming!");
        }
    }
}
