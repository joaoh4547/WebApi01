using Microsoft.AspNetCore.Mvc;

namespace WebApi01.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    public IActionResult Get(int id, [FromHeader] string name)
    {
        var user = new User
        {
            Id = id,
            Age = 25,
            Name = name
        };
        return Ok(user);
    }
}
