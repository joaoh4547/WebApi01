using Microsoft.AspNetCore.Mvc;

namespace WebApi01.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        var response = new Response
        {
            Age = 25,
            Name = "João"
        };
        return Ok(response);
    }
}
