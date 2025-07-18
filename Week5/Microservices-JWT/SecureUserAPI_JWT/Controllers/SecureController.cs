using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [Authorize]
        [HttpGet("secret")]
        public IActionResult GetSecret()
        {
            var username = User.Identity?.Name;
            return Ok($"Welcome, {username}! This is a protected message.");
        }
    }
}

