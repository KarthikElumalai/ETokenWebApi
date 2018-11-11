using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETokenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        // GET api/Login/5
        [HttpGet("{username}")]
        public ActionResult<string> Get(string  username)
        {

            if (username == "sachin")
            {
                return "Valid User";
            }
            return "Not Valid User";
        }
    }
}