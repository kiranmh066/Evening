using System;
using System.Collections.Generic;
using System.Text;
using BookShowDAL;
using BookShowEntity;

namespace BookShow
{
    public class MoviePL
    {
        public void MovieMenuPL()
        {
            Console.WriteLine("Enter 1 to Add Movie \n" +
                "Enter 2 to Update Movie \n" +
                "Enter 3 to Delete Movie \n " +
                "Enter 4 to Show All Movie \n" +
                "Enter 5 to Search Movie By Id \n" +
                "Enter 6 to Search Movie By Type \n" +
                //"Enter 7 to Search Movie By Name \n" +
                "Enter  to Exit"
                );

            int enter = Convert.ToInt32(Console.ReadLine());
            MoviePL moviePLObj = new MoviePL();

            switch (enter)
            {
                case 1:
                    moviePLObj.AddMoviePL();
                    moviePLObj.MovieMenuPL();
                    break;
                case 2:
                    moviePLObj.UpdateMoviePL();
                    moviePLObj.MovieMenuPL();
                    break;
                case 3:
                    moviePLObj.DeleteMoviePL();
                    moviePLObj.MovieMenuPL();
                    break;
                case 4:
                    moviePLObj.ShowAllMoviesPL();
                    moviePLObj.MovieMenuPL();
                    break;
                case 5:
                    moviePLObj.ShowMovieByIdPL();
                    moviePLObj.MovieMenuPL();
                    break;
                case 6:
                    moviePLObj.ShowMovieByTypePL();
                    moviePLObj.MovieMenuPL();
                    break;
                default:
                    Console.WriteLine("Better Luck Next Time :)");
                    break;
            }
        }
        public void AddMoviePL()
        {
            MovieOperationDAL MovieOperationDALObj = new MovieOperationDAL();
            Movie movieObj = new Movie();

            Console.WriteLine("Enter MovieName: ");
            movieObj.Name = Console.ReadLine();
            Console.WriteLine("Enter Movie Description: ");
            movieObj.MovieDesc = Console.ReadLine();
            Console.WriteLine("Enter Movie Type: ");
            movieObj.MovieType = Console.ReadLine();

            string msg = MovieOperationDALObj.AddMovie(movieObj);
            Console.WriteLine(msg);
        }

        public void UpdateMoviePL()
        {
            MovieOperationDAL MovieOperationDALObj = new MovieOperationDAL();
            Movie movieObj = new Movie();

            Console.WriteLine("Enter MovieId: ");
            movieObj.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter MovieName: ");
            movieObj.Name = Console.ReadLine();
            Console.WriteLine("Enter Movie Description: ");
            movieObj.MovieDesc = Console.ReadLine();
            Console.WriteLine("Enter Movie Type: ");
            movieObj.MovieType = Console.ReadLine();

            string msg = MovieOperationDALObj.UpdateMovie(movieObj);
            Console.WriteLine(msg);
        }

        public void DeleteMoviePL()
        {

            MovieOperationDAL MovieOperationDALObj = new MovieOperationDAL();
            //Movie movieObj = new Movie();

            Console.WriteLine("Enter MovieId: ");
            int movieId = Convert.ToInt32(Console.ReadLine());

            string msg = MovieOperationDALObj.DeleteMovie(movieId);
            Console.WriteLine(msg);
        }


        public void ShowAllMoviesPL()
        {
            MovieOperationDAL MovieOperationDALObj = new MovieOperationDAL();
            List<Movie> movieList = MovieOperationDALObj.ShowAllMovie();

            foreach (var item in movieList)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Description: " + item.MovieDesc);
                Console.WriteLine("Type: " + item.MovieType);
            }
        }

        public void ShowMovieByIdPL()
        {
            MovieOperationDAL MovieOperationDALObj = new MovieOperationDAL();
            Console.WriteLine("Enter MovieId: ");
            int movieId = Convert.ToInt32(Console.ReadLine());
            Movie movie = MovieOperationDALObj.ShowMovieById(movieId);

            Console.WriteLine(movie.Name);
            Console.WriteLine(movie.MovieDesc);
            Console.WriteLine(movie.MovieType);
        }

        public void ShowMovieByTypePL()
        {
            MovieOperationDAL MovieOperationDALObj = new MovieOperationDAL();
            Console.WriteLine("Enter MovieType: ");
            string movieType = Console.ReadLine();
            List<Movie> movieList = MovieOperationDALObj.ShowMovieByType(movieType);

            foreach (var item in movieList)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name: " + item.Name);
            }
        }

        /*public void SearchByNamePL()
        {
            MovieOperationDAL MovieOperationDALObj = new MovieOperationDAL();
            Console.WriteLine("Enter MovieName: ");
            string movieName = Console.ReadLine();
            List<Movie> movieList = MovieOperationDALObj.SearchMovieByName(movieName);

            foreach (var item in movieList)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Name: " + item.Name);
            }
        }*/
    }
}
