using System;
using System.Security.Claims;
using System.Text;
using LifeNotes.Models;

namespace LifeNotes.services
{
    public class JwtService
    {


        public string CreateToken(AuthenticateModel authenticateModel)
        {
            //byte[] key = Encoding.ASCII.GetBytes(AppSettings.S_Secret.Value);
            //SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(new Claim[]
            //    {
            //        new Claim(ClaimTypes.Name, user.Id.ToString())
            //    }),
            //    Expires = DateTime.UtcNow.AddDays(7),
            //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            //};

            //JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            //SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            //return tokenHandler.WriteToken(token);
            string token = null;
            return token;
        }
    }
}


	