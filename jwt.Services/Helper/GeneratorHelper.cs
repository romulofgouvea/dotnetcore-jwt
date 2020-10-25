using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;

namespace jwt.Services.Helper
{
    public static class GeneratorHelper
    {
        public static string GeneratePassword(string password)
        {
            byte[] salt = new byte[128 / 8];

            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 1000,
            numBytesRequested: 256 / 8));
        }
    }
}
