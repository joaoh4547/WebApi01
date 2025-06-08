using Microsoft.AspNetCore.Mvc;

namespace WebApi01.Controllers;

public class TestController : AppBaseController
{

    [HttpGet]
    public IActionResult Get()
    {
        var key = GetKey();

        return Ok(key);
    }
}
