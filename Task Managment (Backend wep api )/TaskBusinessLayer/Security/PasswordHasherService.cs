using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace TaskBusinessLayer.Security
{
    public class PasswordHasherService
    {
        private readonly static PasswordHasher<object> _Hasher = new();

        public static string HashPassword(string password)
        {
            return _Hasher.HashPassword(null,password);
        }

        public static bool VerifyPassword(string HashedPassword,string password)
        {
            var result = _Hasher.VerifyHashedPassword(null, HashedPassword, password);

            return result== PasswordVerificationResult.Success;
        }

    }
}
