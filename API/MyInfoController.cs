using Microsoft.AspNetCore.Mvc;

namespace AboutMe.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyInfoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetInfo()
        {
            return new JsonResult(new { message = "Hello! This is information about me." });
        }
    }
}