using BookShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShowDAL.Repost
{
    public class MovieOperationRepository:IMovieOperationRepository
    {
        BookShowDbContext _dbContext;

        public MovieOperationRepository(BookShowDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddMovie(Movie movie)
        {
            _dbContext.movies.Add(movie);
            _dbContext.SaveChanges();
        }

        public void DeleteMovie(int moviId)
        {
            var movie= _dbContext.movies.Find(moviId);
            _dbContext.movies.Remove(movie);
            _dbContext.SaveChanges();
        }
        public Movie GetMovieById(int movieId)
        {
            return _dbContext.movies.Find(movieId);
        }

        public IEnumerable<Movie>GetMovies()
        {
            return _dbContext.movies.ToList();
        }

        public void UpdateMovie(Movie movie)
        {
            _dbContext.Entry(movie).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

    
    }
}
