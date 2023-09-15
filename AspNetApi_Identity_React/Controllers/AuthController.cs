using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AspNetApi_Identity_React.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class AuthController : ControllerBase
{
    private readonly IHttpContextAccessor _contextAccessor;

    public AuthController(IHttpContextAccessor contextAccessor) => _contextAccessor = contextAccessor;

    [HttpGet]
    [Route("me")]
    public IActionResult GetUserInfo()
    {
        var mail = _contextAccessor?.HttpContext?.User.Claims.FirstOrDefault(c => string.Equals(c.Type, ClaimTypes.Email))?.Value;

        return Ok(mail);
    }
}
