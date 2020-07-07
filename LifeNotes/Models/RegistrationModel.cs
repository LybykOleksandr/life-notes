using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LifeNotes.Controllers
{
    public class RegistrationModel
    {
        //[Required(ErrorMessage = "Input Login")]
        //[RegularExpression(@"^\w{6,20}", ErrorMessage = "input another login")]
        //public string Username { get; set; }

        //[Required(ErrorMessage = "Input Password")]
        //[RegularExpression(@"^\w{6,20}", ErrorMessage = "input another password")]
        //public string Password { get; set; }

        //[Required(ErrorMessage = "Input PasswordConfirm")]
        //[Compare("Password", ErrorMessage = "must match the password")]
        //public string PasswordConfirm { get; set; }

        //[Required(ErrorMessage = "Input Email")]
        //[EmailAddress(ErrorMessage = "Input Email")]
        //public string Email { get; set; }

        //[Range(1, 1, ErrorMessage = "accept")]
        //public bool Accept { get; set; }




        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }














        //    public bool ValidateLogin()
        //    {
        //        string pattern = @"^(.{0,7}|[^0-9]*|[^A-Z])$";

        //        return Regex.IsMatch(Login, pattern, RegexOptions.IgnoreCase);
        //    }


        //    public bool ValidatePassword()
        //    {
        //        string pattern = @"^(.{0,7}|[^0-9]*|[^A-Z])$";
        //        return (Regex.IsMatch(Password, pattern, RegexOptions.IgnoreCase) && Password == PasswordConfirm);
        //    }


        //    public bool ValidateEmail()
        //    {
        //        string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
        //            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

        //        return Regex.IsMatch(Email, pattern, RegexOptions.IgnoreCase);
        //    }

        //    public bool ValidateAccept()
        //    {
        //        return Accept;
        //    }
    }
}