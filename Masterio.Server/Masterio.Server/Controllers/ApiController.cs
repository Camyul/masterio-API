using Microsoft.AspNetCore.Mvc;

namespace Masterio.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public abstract class ApiController : ControllerBase
    {
    }
}
