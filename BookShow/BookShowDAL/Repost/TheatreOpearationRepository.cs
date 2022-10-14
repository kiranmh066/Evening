using BookShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShowDAL.Repost
{
    public class TheatreOpearationRepository : ITheatreOpearationRepository
    {
        BookShowDbContext _dbContext;

        public TheatreOpearationRepository(BookShowDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void AddTheatre(Theatre theatre)
        {
            _dbContext.theatre.Add(theatre);
            _dbContext.SaveChanges();
        }

        public void DeleteTheatre(int theatreId)
        {
            var theatre = _dbContext.theatre.Find(theatreId);
            _dbContext.theatre.Remove(theatre);
            _dbContext.SaveChanges();
        }

        public Theatre GetTheatreById(int theatreId)
        {
            return _dbContext.theatre.Find(theatreId);
        }

        public IEnumerable<Theatre> GetTheatres()
        {
            return _dbContext.theatre.ToList();
        }

        public void UpdateTheatre(Theatre theatre)
        {
            _dbContext.Entry(theatre).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
