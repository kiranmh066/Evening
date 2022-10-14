using BookShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShowDAL.Repost
{
    public class BookTicketRepository : IBookTicketRepository
    {
        private BookShowDbContext _dbContext;
        public BookTicketRepository(BookShowDbContext dbContext)
        {
            _dbContext=dbContext;
        }
        public void AddBooki(BookTicket bookTicket)
        {
            _dbContext.tblbook.Add(bookTicket);
            _dbContext.SaveChanges();
        }

        public void DeleteBooki(int bookId)
        {
            var booking = _dbContext.tblbook.Find(bookId);
            _dbContext.tblbook.Remove(booking);
            _dbContext.SaveChanges();
        }

        public IEnumerable<BookTicket> GetBookers()
        {
            return _dbContext.tblbook.ToList();
        }

        public BookTicket GetBookiById(int bookId)
        {
            return _dbContext.tblbook.Find(bookId);
        }

        public void UpdateBooki(BookTicket bookTicket)
        {
            _dbContext.Entry(bookTicket).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
