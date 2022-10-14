using BookShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BookShowDAL
{
    public class MovieOperationDAL
    {
        BookShowDbContext db = null;

        public MovieOperationDAL(BookShowDbContext db)
        {
            this.db = db;
        }

        public string AddMovie(Movie movie)
        {
            /*db = new BookShowDbContext();*/
            db.movies.Add(movie);
            db.SaveChanges();

            return "Saved";
        }
        public string UpdateMovie(Movie movie)
        {

           /* db = new BookShowDbContext();*/
            db.Entry(movie).State = EntityState.Modified;
            db.SaveChanges();

            return "Updated";
        }
        public string DeleteMovie(int movieId)
        {

            /*db = new BookShowDbContext();*/
            Movie movieObj = db.movies.Find(movieId);
            db.Entry(movieObj).State = EntityState.Deleted;
            db.SaveChanges();

            return "Deleted";
        }
        public List<Movie> ShowAllMovie()
        {

            /*db = new BookShowDbContext();*/
            List<Movie> movieList = db.movies.ToList();

            return movieList;
        }

        public List<Movie> ShowMovieByType(string type)
        {
           /* db = new BookShowDbContext();*/
            List<Movie> movieList = db.movies.ToList();

            //Linq query- select * from movie where movietype='type'
            var result = from movies in movieList
                         where movies.MovieType == type
                         select new Movie
                         {
                             Id = movies.Id,
                             Name = movies.Name,
                         };
            List<Movie> movieResult = new List<Movie>();
            foreach (var item in result) // Linq Query execution
            {
                movieResult.Add(item);

            }
            return movieResult;
        }

        public Movie ShowMovieById(int movieId)
        {

            /*db = new BookShowDbContext();*/
            Movie movie = db.movies.Find(movieId);

            return movie;
        }

        /*public Movie SearchMovieByName(string movieName)
        {
            db = new BookShowDbContext();
            List<Movie> movieList = db.movies.ToList();

            //Linq query- select * from movie where movietype='type'
            var result = from movies in movieList
                         where movies.MovieType == movieName
                         select new Movie
                         {
                             Id = movies.Id,
                             Name = movies.Name,
                         };
            List<Movie> movieResult = new List<Movie>();
            foreach (var item in result) // Linq Query execution
            {
                movieResult.Add(item);

            }
            return movieResult;
        }*/
    }
}
