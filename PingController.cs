using Microsoft.AspNetCore.Mvc;

namespace TodoNetRjsSql.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API online");
        }
    }
}