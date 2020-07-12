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

        

        [HttpPost]
        public IActionResult Registrate(RegistrationModel registrationModel)
        {
            UserService userService = new UserService();
            if (userService.Registrate(registrationModel))
            {
                return StatusCode(201);
            }
            else
            {
                return StatusCode(409,new { message = "Email is alrady in use."});
            }
        }
    }
}