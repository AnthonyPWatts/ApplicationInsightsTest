using Microsoft.AspNetCore.Mvc;

namespace ApplicationInsightsTest.Website.Controllers
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