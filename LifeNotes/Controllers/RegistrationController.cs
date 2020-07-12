using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LifeNotes.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {

        private UserService _userService;

        public RegistrationController(UserService userService)
        {
            _userService = userService;
        }



        [HttpPost]
        public IActionResult Registrate(RegistrationModel registrationModel)
        {

            if (_userService.Registrate(registrationModel))
            {
                return StatusCode(201);
            }
            else
            {
                return StatusCode(409);
            }
        }
    }
}