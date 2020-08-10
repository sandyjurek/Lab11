using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ansYes = true;

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list.");
            Console.WriteLine();

            do
            {
                Console.WriteLine("What category are you interested in? (pick: animated, drama, horror, or scifi: )");

                var userInput = Console.ReadLine();

                var isMovieList = Enum.TryParse(userInput, out MovieCategory movieCategory);

                if (isMovieList)
                {
                    IMovies movies;

                    switch (movieCategory)
                    {
                        case MovieCategory.Animated:
                            movies = new Animated();
                            movies.MyMovieList();
                            break;

                        case MovieCategory.Drama:
                            movies = new Drama();
                            movies.MyMovieList();
                            break;

                        case MovieCategory.SciFi:
                            movies = new SciFi();
                            movies.MyMovieList();
                            break;

                        case MovieCategory.Horror:
                            movies = new Horror();
                            movies.MyMovieList();
                            break;
                        default:
                            break;
                    }
                }

                else if (!isMovieList)
                {
                    Console.WriteLine("You entered incorrrect data.");
                }

                Console.WriteLine("Would you like to continue? (y/n): ");
                string continueAnswer = Console.ReadLine();
                char.TryParse(continueAnswer, out char contAnswer);

                if (contAnswer == 'y' || contAnswer == 'Y')
                {
                    ansYes = true;
                }
                else
                {
                    ansYes = false;
                }
            } 
            
            while (ansYes == true);
            Console.WriteLine("Thanks bye!");
        }
    }
}
