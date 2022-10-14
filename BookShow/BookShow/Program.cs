using BookShowEntity;
using System;

namespace BookShow
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 For Movie \n" +
                "Enter 2 For Theatre \n" +
                "Enter 3 For Show Timing \n " +
                "Enter  to Exit"
                );

            int enter = Convert.ToInt32(Console.ReadLine());
            MoviePL moviePLObj = new MoviePL();
            TheatrePL theatrePLObj = new TheatrePL();
            ShowTimingPL showTimingPLObj = new ShowTimingPL();

            switch (enter)
            {
                case 1:
                    moviePLObj.MovieMenuPL();
                    break;
                case 2:
                    theatrePLObj.TheatreMenuPL();
                    break;
                case 3:
                    showTimingPLObj.ShowTimingMenuPL();
                    break;
                /*case 4:
                    moviePLObj.ShowAllMoviesPL();
                    moviePLObj.MenuPL();
                    break;
                case 5:
                    moviePLObj.ShowMovieByIdPL();
                    moviePLObj.MenuPL();
                    break;
                case 6:
                    moviePLObj.ShowMovieByTypePL();
                    moviePLObj.MenuPL();
                    break;*/
                default:
                    Console.WriteLine("Better Luck Next Time :)");
                    break;
            }
        }
    }
}
