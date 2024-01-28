using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleExeptionHandler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet("GetAll")]
        public Task<IActionResult> GetAllAsync()
        {
            throw new Exception();
        }
    }


}
