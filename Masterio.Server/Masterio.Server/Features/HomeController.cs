using Masterio.Server.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Masterio.Server.Controllers;

public class HomeController : ApiController
{
    [HttpGet]
    [Authorize]
    public ActionResult Get()
    {
        // We don;t need it here. Just example how to get current userId.
        var userId = this.User.GetId();
        //var iserId = 
        var result = $"Works! UserId: {userId}";
        return Ok(result);
    }
}
