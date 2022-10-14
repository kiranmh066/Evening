using BookShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShowDAL.Repost
{
    public class ShowTimingOperationRepository : IShowTimingOperationRepository
    {
        BookShowDbContext _dbContext;
        public ShowTimingOperationRepository(BookShowDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddShow(ShowTiming showTiming)
        {
            _dbContext.showTiming.Add(showTiming);
            _dbContext.SaveChanges();
        }

        public void DeleteShow(int showTimingId)
        {
            var show = _dbContext.showTiming.Find(showTimingId);
            _dbContext.showTiming.Remove(show);
            _dbContext.SaveChanges();
        }

        public IEnumerable<ShowTiming> GetShows()
        {
            return _dbContext.showTiming.ToList();
        }

        public ShowTiming GetShowById(int showTimingId)
        {
            return _dbContext.showTiming.Find(showTimingId);
        }

        public void UpdateShow(ShowTiming showTiming)
        {
            _dbContext.Entry(showTiming).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
