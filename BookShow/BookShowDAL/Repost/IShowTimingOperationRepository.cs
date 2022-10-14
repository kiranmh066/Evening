using BookShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShowDAL.Repost
{
    public interface IShowTimingOperationRepository
    {
        void AddShow(ShowTiming showTiming);

        void UpdateShow(ShowTiming showTiming);

        void DeleteShow(int showTimingId);

        ShowTiming GetShowById(int showTimingId);

        IEnumerable<ShowTiming> GetShows();
    }
}
