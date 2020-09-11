using System;

namespace Lab11
{
    public interface IMovies

    {
        public string Title { get; set; }
        public MovieCategory Category { get; set; }

        public void MyMovieList();
    }
}
