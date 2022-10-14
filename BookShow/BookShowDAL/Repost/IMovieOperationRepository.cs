using BookShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShowDAL.Repost
{
    public interface IMovieOperationRepository
    {
        void AddMovie(Movie movie);

        void UpdateMovie(Movie movie);

        void DeleteMovie(int moviId);

        Movie GetMovieById(int movieId);

        IEnumerable<Movie> GetMovies();
    }
}
