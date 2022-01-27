using Microsoft.AspNetCore.Mvc;

namespace ProjectTemplate
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("test");
        }
    }
}
