using Microsoft.AspNetCore.Mvc;

namespace WebApi01.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class AppBaseController : ControllerBase
{
    protected string GetKey()
    {
        return Request.Headers["X-ACCESS-KEY"].ToString();
    }

    [HttpGet("health")]
    public IActionResult Health()
    {
        return Ok("Its working");
    }
}
