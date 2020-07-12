using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ddController : ControllerBase
    {
        [HttpGet]
        public IActionResult mm()
        {
            return StatusCode(201);
        }
    }
}