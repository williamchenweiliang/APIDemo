using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using apidemo.Models;
using apidemo.Helpers;
using Microsoft.AspNetCore.Http;

namespace apidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        public readonly JwtHelpers _jwt;
        public MemberController(JwtHelpers jwt)
        {
            this._jwt = jwt;
        }

        [HttpPost("~/Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public ActionResult<string> Login(LoginUser user)
        {
            if(CheckUser(user.username, user.password))
            {
                return _jwt.GenerateToken(user.username, expireMinutes:15);
            }
            else
            {
                return BadRequest("帳號密碼有誤");
            }
        }

        public bool CheckUser(string user, string pass)
        {
            return true;
        }
    }

    public class LoginUser
    {
        public string username{get; set;}
        public string password{get; set;}
    }
}