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
    public class AuthenticationController : ControllerBase
    {

		private UserService _userService;
        private JwtService _jwtService;


        public AuthenticationController(UserService userService, JwtService jwtService)
        {
			this._userService = userService;
			this._jwtService = jwtService;
        }



        [HttpPost]
		public IActionResult Authenticate([FromBody] AuthenticateModel authenticateModel)
		{
            UserDTO userDTO = _userService.Authenticate(authenticateModel);
            if (userDTO != null)
            {
                return Ok(userDTO);
            }
            else
            {
                return StatusCode(401);
            }
        }


	}
}
