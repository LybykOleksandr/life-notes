using System;
using System.ComponentModel.DataAnnotations;

namespace LifeNotes.Models
{
    public class UserDB
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string PasswordSalt { get; set; }




    }
}
