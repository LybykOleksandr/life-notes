﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LifeNotes.Controllers;
using LifeNotes.Models;

namespace LifeNotes.services
{
    //public interface IUserService
    //{
    //    Task<User> Authenticate(string email, string password);
    //    Task<IEnumerable<User>> GetAll();
    //}




    public class UserService
    {


        public bool Registrate( RegistrationModel registrationModel)
        {



            return true;
        }




        public UserDTO Authenticate( AuthenticateModel authenticateModel)
        {
            // знайти логін якщо є хапнути сіль + до пароля і хешанути
            PasswordService passwordService = new PasswordService();

            UserDB userDB = null;

            //if(passwordService.PasswordHash(authenticateModel.Password, Salt) == //UserDB.passHash)
            //    {
            //        return UserDB
            //    }
            //authenticateModel.Password += Salt

            UserDTO userDTO = new UserDTO();

            //if (userDB != null)
            //{
            //    JwtService jwtService = new JwtService();
            //    userDTO.Email = userDB.Email;
            //    userDTO.Id = userDB.Id;
            //    userDTO.Username = userDB.Username;
            //    userDTO.Token = jwtService.CreateToken(authenticateModel);
            //}
            //return UserDTO;
            return null;
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



            return errors;
        }

       

    }
}

