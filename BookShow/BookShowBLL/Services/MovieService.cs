using System;
using System.Collections.Generic;
using System.Text;
using BookShowEntity;
using BookShowDAL.Repost;

namespace BookShowBLL.Services
{
    public class MovieService
    {
        IMovieOperationRepository _movieOperationRepository;


        //Unable to resolve ====>>>> Object issues
        public MovieService(IMovieOperationRepository movieOperationRepository)
        {
            _movieOperationRepository = movieOperationRepository;
        }

        //Add Movie
        public void AddMovie(Movie movie)
        {
            _movieOperationRepository.AddMovie(movie);
        }
        //Update Movie
        public void UpdateMovie(Movie movie)
        {
            _movieOperationRepository.UpdateMovie(movie);
        }

        //Delete Movie
        public void DeleteMovie(int moviId)
        {
            _movieOperationRepository.DeleteMovie(moviId);
        }

        //Get MovieByID
        public Movie GetMovieById(int movieId)
        {
           return _movieOperationRepository.GetMovieById(movieId);
        }

        //GetMovies
        public IEnumerable<Movie> GetMovies()
        {
            return _movieOperationRepository.GetMovies();
        }
    }
}
