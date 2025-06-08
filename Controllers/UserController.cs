using Microsoft.AspNetCore.Mvc;
using WebApi01.Communication.Requests;
using WebApi01.Communication.Responses;

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

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUser), StatusCodes.Status201Created)]
    public IActionResult Create(RequestRegisterUser request)
    {
        ResponseRegisterUser response = new ResponseRegisterUser
        {
            Id = 1,
            Name = request.Name,
        };
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update(int id, [FromBody] RequestUpdateUser request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete(int id)
    {
        return NoContent();
    }
}
