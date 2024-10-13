using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNET_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTestController()
        {
            var Friendes= new string[] { "essam", "hossam", "diaa" };
            return Ok(Friendes);
        }
    }
}
