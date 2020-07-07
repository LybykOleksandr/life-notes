using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LifeNotes.Controllers;
using LifeNotes.Models;

namespace LifeNotes.services
{
    public interface IUserService
    {
        Task<User> Authenticate(string email, string password);
        Task<IEnumerable<User>> GetAll();
    }






    //public class UserService : IUserService
    //{
    //    // users hardcoded for simplicity, store in a db with hashed passwords in production applications
    //    private List<User> _users = new List<User>
    //    {
    //        new User { Id = 1, Username = "Name", Password = "test123", Email = "test123" }
    //    };

    //    public async Task<User> Authenticate(string email, string password)
    //    {
    //        var user = await Task.Run(() => _users.SingleOrDefault(x => x.Email == email && x.Password == password));

    //        // return null if user not found
    //        if (user == null)
    //            return null;

    //        // authentication successful so return user details without password
    //        return user.WithoutPassword();
    //    }

    //    public async Task<IEnumerable<User>> GetAll()
    //    {
    //        return await Task.Run(() => _users.WithoutPasswords());
    //    }
    //}


    public class UserService
    {


        public bool Registration( RegistrationModel registrationModel)
        {

            return true;
        }

        


        //public bool ValidateLogin(string username)
        //{
        //    string pattern = @"^(.{0,7}|[^0-9]*|[^A-Z])$";

        //    return Regex.IsMatch(username, pattern, RegexOptions.IgnoreCase);
        //}


        //public bool ValidatePassword()
        //{
        //    string pattern = @"^(.{0,7}|[^0-9]*|[^A-Z])$";
        //    return (Regex.IsMatch(Password, pattern, RegexOptions.IgnoreCase) && Password == PasswordConfirm);
        //}


        //public bool ValidateEmail()
        //{
        //    string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
        //        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

        //    return Regex.IsMatch(Email, pattern, RegexOptions.IgnoreCase);
        //}

        //public bool ValidateAccept()
        //{
        //    return Accept;
        //}




        public IEnumerable<ValidationResult> Validate(RegistrationModel registrationModel)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            //if (!Regex.IsMatch(registrationModel.Username, @"^(.{0,7}|[^0-9]*|[^A-Z])$", RegexOptions.IgnoreCase))
            //    errors.Add(new ValidationResult("Не указано имя"));

            //if (string.IsNullOrWhiteSpace(this.Id))
            //    errors.Add(new ValidationResult("Не указан идентификатор пользователя"));

            //if (this.Age < 1 || this.Age > 100)
            //    errors.Add(new ValidationResult("Недопустимый возраст"));



            //чекнути юзернейм і мило в базі


            return errors;
        }

       

    }
}

