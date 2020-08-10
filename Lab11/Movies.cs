using System;

namespace Lab11
{
    public interface IMovies

    {
        public string Title { get; set; }
        public string Category { get; set; }

        public void MyMovieList();
    }
}
