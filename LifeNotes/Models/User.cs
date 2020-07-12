﻿using System.ComponentModel.DataAnnotations;

namespace LifeNotes.Models
{
    public class User
    {


        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }


        public string Token { get; set; }




    }
}
