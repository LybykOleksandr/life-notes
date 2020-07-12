using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeNotes.Models;
using LifeNotes.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {



        [HttpPost]
        public IActionResult Login([FromBody] AuthenticateModel authenticateModel)
        {
            UserService userService = new UserService();
            UserDTO userDTO = userService.Authenticate(authenticateModel);
            if (userDTO != null)
            {
                return Ok(userDTO);
            }
            else
            {
                return StatusCode(401, new { message = "lala" });
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            
                return StatusCode(401, new { message = "lala"});
            
        }


    }
}
