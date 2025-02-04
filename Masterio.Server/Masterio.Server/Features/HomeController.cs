using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Masterio.Server.Controllers;

public class HomeController : ApiController
{
    [Authorize]
    public ActionResult Get()
    {
        return Ok("Works!");
    }
}
