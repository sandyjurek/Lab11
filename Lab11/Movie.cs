using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Movie : IMovies
    {
        public string Title { get; set; }
        public MovieCategory Category { get; set; }
        public List<IMovies> Movies { get; set; }

        public Movie()
        {
            Movies = new List<IMovies>();
            Movies.Add(new Movie("Men in Black", MovieCategory.SciFi));
            Movies.Add(new Movie("Animated Movies", MovieCategory.Animated));
            Movies.Add(new Movie("Drama movie", MovieCategory.Drama));
            Movies.Add(new Movie("Men in Black", MovieCategory.SciFi));
            Movies.Add(new Movie("Men in Black", MovieCategory.SciFi));
            Movies.Add(new Movie("Halloween", MovieCategory.Horror));
        }

        public Movie(string title, MovieCategory category)
        {
            Title = title;
            Category = category;
        }

        public void MyMovieList()
        {
            throw new NotImplementedException();
        }
    }
}
