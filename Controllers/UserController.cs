using Microsoft.AspNetCore.Mvc;
using WebApi01.Communication.Requests;
using WebApi01.Communication.Responses;

namespace WebApi01.Controllers;

public class UserController : AppBaseController
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

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>() {
            new User
            {
                Id = 1,
                Age = 25,
                 Name = "João"
            },
            new User
            {
                Id = 2,
                Age = 22,
                Name = "Maria"
            }
        };
        return Ok(response);
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

    [HttpPut("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword(RequestChangePassword request)
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
