using BookShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShowDAL.Repost
{
    public interface IBookTicketRepository
    {
        void AddBooki(BookTicket bookTicket);
        void UpdateBooki(BookTicket bookTicket);

        void DeleteBooki(int bookId);

        BookTicket GetBookiById(int bookId);

        IEnumerable<BookTicket> GetBookers();
    }
}
