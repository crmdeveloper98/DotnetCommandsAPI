using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace src.DotnetCommandsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DotnetCommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new [] {"This", "is", "a", "hard", "coded", "string"};
        }
    }
}