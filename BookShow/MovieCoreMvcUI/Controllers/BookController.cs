using BookShowEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieCoreMvcUI.Controllers
{
    public class BookController : Controller
    {
        private IConfiguration _configuration;

        public BookController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<BookTicket> bookTicketresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "BookTicket/GetBookTickets";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        bookTicketresult = JsonConvert.DeserializeObject<IEnumerable<BookTicket>>(result);
                    }
                }
            }
            return View(bookTicketresult);
        }
        public IActionResult BookEntry()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BookEntry(BookTicket bookTicket)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(bookTicket), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "BookTicket/AddBooki";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Booking Ticket deatils Saved Successfully";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong Entries....!!!  :)";
                    }
                }
            }

            return View();
        }

        public async Task<IActionResult> EditBook(int bookiID)
        {

            BookTicket bookTicket = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "BookTicket/GetBookById?bookiId=" + bookiID;
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        bookTicket = JsonConvert.DeserializeObject<BookTicket>(result);
                    }
                }
            }

            return View(bookTicket);
        }

        [HttpPost]
        public async Task<IActionResult> EditBook(BookTicket bookTicket)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(bookTicket), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "BookTicket/UpdateBookTicket";
                using (var response = await client.PutAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Book ticket deatails Saved Successfully";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong Entries....!!!  :)";
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> DeleteBook(int BookiId)
        {
            BookTicket bookTicket = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "BookTicket/GetBookById?bookiId=" + BookiId;
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        bookTicket = JsonConvert.DeserializeObject<BookTicket>(result);
                    }
                }
            }

            return View(bookTicket);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBook(BookTicket bookTicket)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {

                string endpoint = _configuration["WebApiBaseUrl"] + "BookTicket/DeleteBookTicket?bookiId=" + bookTicket.Id;
                using (var response = await client.DeleteAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Book Ticket details No Longer available of this credentials";
                    }
                    else
                    {
                        ViewBag.staus = "Error";
                        ViewBag.message = "Soory...   Wrong Entries     :)";
                    }
                }
            }
            return View();
        }

    }
}
