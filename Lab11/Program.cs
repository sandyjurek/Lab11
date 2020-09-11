using System;

namespace Lab11
{
    class Program
    {//adding comment
        static void Main(string[] args)
        {
            bool ansYes = true;
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list.");
            Console.WriteLine();

            do
            {
                Console.WriteLine("What category are you interested in? (Animated, Drama, Horror, or SciFi):");
                var userInput = Console.ReadLine();

                Movie movie = new Movie();
                string input = Console.ReadLine().ToLower().Trim();



                foreach (var mov in movie.Movies)
                {


                    if (input == mov.Category.ToString().ToLower())
                    {
                        Console.WriteLine(mov.Title);
                        Console.WriteLine(mov.Category);
                    }

                    else
                    {
                        Console.WriteLine("You entered incorrrect data.");
                    }
                }


                Console.WriteLine("Would you like to continue? (y/n): ");
                Console.WriteLine("_______________________");
                string continueAnswer = Console.ReadLine();
                char.TryParse(continueAnswer, out char contAnswer);

                if (contAnswer)
                {

                }

                    while (contAnswer())

                    {
                         Console.WriteLine("bye");
                    }
                
                   
                    else
                    {
                        ansYes == false;
                    }

            
            
    

        //var isMovieList = Enum.TryParse(userInput, out MovieCategory movieCategory);

        //if (isMovieList)
        //{
        //    IMovies movies;

        //    switch (movieCategory)
        //    {
        //        case MovieCategory.Animated:
        //            movies = new Animated();
        //            movies.MyMovieList();
        //             break;

        //         case MovieCategory.Drama:
        //             movies = new Drama();
        //             movies.MyMovieList();
        //            break;

        //         case MovieCategory.SciFi:
        //            movies = new SciFi();
        //             movies.MyMovieList();
        //             break;

        //         case MovieCategory.Horror:
        //             movies = new Horror();
        //             movies.MyMovieList();
        //             break;
        //         default:
        //             break;
        //     }
        // }
