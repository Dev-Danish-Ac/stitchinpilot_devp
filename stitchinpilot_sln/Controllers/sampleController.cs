using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StitchinPilot_Devp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sampleController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Second Controller");
        }
    }
}
