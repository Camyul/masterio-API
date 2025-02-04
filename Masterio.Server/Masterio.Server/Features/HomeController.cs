using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Masterio.Server.Controllers;

public class HomeController : ApiController
{
    [HttpGet]
    [Authorize]
    public ActionResult Get()
    {
        return Ok("Works!");
    }
}
