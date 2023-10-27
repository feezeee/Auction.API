using Microsoft.AspNetCore.Mvc;

namespace Categories.API.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(
            CancellationToken cancellationToken = default)
        {
            return Ok(new
            {
                id = Guid.NewGuid(),
                name = "test 1"
            });
        }
    }
}