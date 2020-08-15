using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using apidemo.Models;

namespace apidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {
        }

        // GET api/values
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Getstrings()
        {
            return new List<string> { };
        }
    }
}