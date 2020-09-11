using System;
using System.Collections.Generic;

namespace Lab11
{
    public class Horror : IMovies
    {
        public string Title { get; set; }
        public MovieCategory Category { get; set; }

        public void MyMovieList()
        {
            List<string> MovieList = new List<string>();
            MovieList.Add("Nightmare on Elm Street");
            MovieList.Add("Halloween");
            MovieList.Add("Nightmare Before Christmas");
            MovieList.Add("Devil in Blue Dress");

            foreach (string movie in MovieList)
            {
                Console.WriteLine(movie);
                Console.WriteLine("---------------------");
            }
        }
    }
}
