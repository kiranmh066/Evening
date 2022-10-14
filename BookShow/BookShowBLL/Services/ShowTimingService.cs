using BookShowDAL.Repost;
using BookShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShowBLL.Services
{
    public class ShowTimingService
    {
        IShowTimingOperationRepository _showRepository;

        public ShowTimingService(IShowTimingOperationRepository showRepository)
        {
            _showRepository = showRepository;
        }

        //Add Movie
        public void AddShow(ShowTiming showTiming)
        {
            _showRepository.AddShow(showTiming);
        }
        //Update Movie
        public void UpdateShow(ShowTiming showTiming)
        {
            _showRepository.UpdateShow(showTiming);
        }

        //Delete Movie
        public void DeleteShow(int showId)
        {
            _showRepository.DeleteShow(showId);
        }

        //Get MovieByID
        public ShowTiming GetShowById(int showId)
        {
            return _showRepository.GetShowById(showId);
        }

        //GetMovies
        public IEnumerable<ShowTiming> GetShows()
        {
            return _showRepository.GetShows();
        }


    }
}
