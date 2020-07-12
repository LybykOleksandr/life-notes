using System;
using System.Security.Cryptography;

namespace LifeNotes.services
{
    public class PasswordService
    {

        public string PasswordHash(string password, string salt)
        {
            string passwordHash = password + salt;

            for (int i = 0; i < 1111111; i++)
            {
                passwordHash = passwordHash.GetHashCode().ToString();
            }

            return passwordHash;
        }



        public string GenerateSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }




    }
}
