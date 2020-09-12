using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTRkDemo.Models;
using JWTRkDemo.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTRkDemo.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {

            var userauthe = authenticationService.Authenticate(user.UserName, user.Password);
            if (userauthe == null)
            {
                return BadRequest(new { message = "username or pwd is not correcct" });
            }
            return Ok(userauthe);
        }

    }

    //step1:
    //    in postman send post request
    //     post   https://localhost:44380/api/authentication

    //    body:
    //        {
    //          "username":"testusername",
    //          "password":"12345"
    //        }
    //step 2:
    // once token genearated in postman response , copy paste that token
    // in Get -> Authorization -> Type = Bearer Token -> paste the generated token over here 
    //

}
