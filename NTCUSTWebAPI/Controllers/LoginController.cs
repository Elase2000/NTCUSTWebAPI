using NTCUSTWebAPI.Model;
using NTCUSTWebAPI.Models;
using Swashbuckle.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NTCUSTWebAPI.Controllers
{
    [RoutePrefix("Login")]
    public class LoginController : ApiController
    {
        [Route("")]
        [SwaggerRequestExample(typeof(LoginModel), typeof(LoginModelExample))]
        public IHttpActionResult Post([FromBody] LoginModel Login)
        {
            if (((Login.Account == "Tom") && (Login.Password == "123456")) ||
                ((Login.Account == "Mary") && (Login.Password == "111111")))
            {
                return Ok();
            }
            else
            {
                return BadRequest("帳號密碼錯誤");
            }
        }
    }
}
