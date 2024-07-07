using Microsoft.AspNetCore.Mvc;

namespace Fastorant.Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvinceController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok("Hola");
        }
    }
}
