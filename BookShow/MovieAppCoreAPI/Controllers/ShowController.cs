using BookShowBLL.Services;
using BookShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieAppCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private ShowTimingService _movieService;

        public ShowController(ShowTimingService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetShows")]//
        public IEnumerable<ShowTiming> GetShows()
        {
            return _movieService.GetShows();
        }

        [HttpPost("AddShow")]
        public IActionResult AddShow([FromBody] ShowTiming show)
        {
            _movieService.AddShow(show);
            return Ok("Show created Successfully");
        }

        [HttpDelete("DeleteShow")]
        public IActionResult DeleteShow(int showId)
        {
            _movieService.DeleteShow(showId);
            return Ok("Show deleted Successfully");
        }

        [HttpPut("UpdateShow")]
        public IActionResult UpdateShow([FromBody] ShowTiming show)
        {
            _movieService.UpdateShow(show);
            return Ok("Show Updated Successfully");
        }
        [HttpGet("GetShowById")]
        public ShowTiming GetShowById(int showId)
        {
            return _movieService.GetShowById(showId);
        }
    }
}
