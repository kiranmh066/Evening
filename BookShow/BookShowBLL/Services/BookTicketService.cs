using BookShowDAL.Repost;
using BookShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShowBLL.Services
{
    public class BookTicketService
    {
        IBookTicketRepository _bookRepository;


        //Unable to resolve ====>>>> Object issues
        public BookTicketService(IBookTicketRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        //Add Booking
        public void AddBooki(BookTicket bookTicket)
        {
            _bookRepository.AddBooki(bookTicket);
        }
        //Update Booking
        public void UpdateBooking(BookTicket bookTicket)
        {
            _bookRepository.UpdateBooki(bookTicket);
        }

        //Delete Booking
        public void DeleteBooking(int bookiId)
        {
            _bookRepository.DeleteBooki(bookiId);
        }

        //Get BookiByID
        public BookTicket GetBookiById(int bookiId)
        {
            return _bookRepository.GetBookiById(bookiId);
        }

        //Get Users
        public IEnumerable<BookTicket> GetBookers()
        {
            return _bookRepository.GetBookers();
        }
    }
}
