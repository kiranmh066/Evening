using BookShowBLL.Services;
using BookShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieAppCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTicketController : ControllerBase
    {
        private BookTicketService _bookTicketService;

        public BookTicketController(BookTicketService bookTicketService)
        {
            _bookTicketService = bookTicketService;
        }

        [HttpGet("GetBookTickets")]//
        public IEnumerable<BookTicket> GetBookers()
        {
            return _bookTicketService.GetBookers();
        }

        [HttpPost("AddBooki")]
        public IActionResult AddBooki([FromBody] BookTicket bookTicket)
        {
            _bookTicketService.AddBooki(bookTicket);
            return Ok("BookTicket created Successfully");
        }

        [HttpDelete("DeleteBookTicket")]
        public IActionResult DeleteBooki(int bookiId)
        {
            _bookTicketService.DeleteBooking(bookiId);
            return Ok("BookTicket deleted Successfully");
        }

        [HttpPut("UpdateBookTicket")]
        public IActionResult UpdateBookTicket([FromBody]BookTicket bookTicket)
        {
            _bookTicketService.UpdateBooking(bookTicket);
            return Ok("BookTicket Updated Successfully");
        }

        [HttpGet("GetBookById")]
        public BookTicket GetBookiById(int bookiId)
        {
            return _bookTicketService.GetBookiById(bookiId);
        }
    }
}
