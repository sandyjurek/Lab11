using System;


namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputForMovies();
        }

        public static void UserInputForMovies()
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list.");
            Console.WriteLine("What category are you interested in? (pick: animated, drama, horror, or scifi: )");

            var userInput = Console.ReadLine();

            var isMovieList = Enum.TryParse(userInput, out MovieCategory movieCategory);

            if (isMovieList)
            {
                Movies movies;

                switch (movieCategory)
                {
                    case MovieCategory.Animated:
                        movies = new Animated();
                        movies.VroomVroom();
                        break;

                    case MovieCategory.Drama:
                        movies = new Drama();
                        movies.VroomVroom();
                        break;

                    case MovieCategory.SciFi:
                        movies = new SciFi();
                        movies.VroomVroom();
                        break;

                    case MovieCategory.Horror:
                        movies = new Horror();
                        movies.VroomVroom();
                        break;
                }
            }
        }
    }
}
