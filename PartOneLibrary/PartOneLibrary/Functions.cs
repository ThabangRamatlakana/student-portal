using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace PartOneLibrary
{
    public class Functions
    {
        public Functions()
        {
                
        }
        public string HashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypted_bytes = sha1.ComputeHash(password_bytes);
            return Convert.ToBase64String(encrypted_bytes);
        }

        public string ConnectionString()
        {
            const string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
            return conString;
        }
    }
}
