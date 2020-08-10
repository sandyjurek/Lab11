using System;

namespace Lab11
{
    public class Drama : IMovies
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public void MyMovieList()
        {
            Console.WriteLine("Relationships");
            Console.WriteLine("FailedHopes");
            Console.WriteLine("Mystery");
            Console.WriteLine("Detective");
            Console.WriteLine("Crime");
            Console.WriteLine("Lifetime");
            Console.WriteLine("Funeral");
            Console.WriteLine("Coffin");
            Console.WriteLine("Chase");
            Console.WriteLine("Parade");
        }
    }
}

