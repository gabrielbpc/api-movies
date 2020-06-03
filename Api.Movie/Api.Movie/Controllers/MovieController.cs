using Api.Movie.Interfaces;
using Api.Movie.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Movie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] IMovieService service)
        {
            var result = service.CreateJsonFileWithValues();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromServices] IMovieService service, [FromBody] VideoElement video)
        {
            var result = service.UpdateJsonFileWithValue(video);

            return Ok(result);
        }
    }
}