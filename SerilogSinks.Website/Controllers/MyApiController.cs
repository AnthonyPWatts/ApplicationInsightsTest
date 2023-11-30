using Microsoft.AspNetCore.Mvc;

namespace SerilogSinks.Website.Controllers
{
    [ApiController]
    [Route("MyApi")]
    public class MyApiController : ControllerBase
    {
        [HttpGet]
        [Route("Example")]
        public IActionResult Example()
        {
            return Ok("Unexciting");
        }
    }
}