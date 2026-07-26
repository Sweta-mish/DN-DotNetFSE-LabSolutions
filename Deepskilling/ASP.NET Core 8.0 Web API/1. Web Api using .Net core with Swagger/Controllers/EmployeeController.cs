using Microsoft.AspNetCore.Mvc;

namespace _1._Web_Api_using_.Net_core_with_Swagger.Controllers
{
    [Route("Emp")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to Employee API");
        }
    }
}