using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LegendBankBeta.Lib.Commons
{
    public class Utilities
    {
        /// <summary>
        /// Generates Random Numbers as Account Numbers
        /// </summary>
        public static string GenerateNum()
        {
            Random rand = new Random();
            int a = rand.Next(10000, 100000);
            int b = rand.Next(10000, 100000);
            string x = a.ToString() + b.ToString();
            return x;
        }
        
        /// <summary>
        /// clean string to remove digit at the begining 
        /// </summary>
        /// <param name="val"></param>
        public static string RemoveDigitFromStart(string val)
        {
            var str = val.Substring(0, 1).ToCharArray();
            var strCode = (int)str[0];
            if (strCode >= 48 && strCode <= 57)
            {
                return RemoveDigitFromStart(val.Substring(1));
            }

            return val;
        }

        /// <summary>
        /// Change first character to caps     
        /// </summary>
        /// <param name="val"></param>
        public static string FirstCharacterToUpper(string val)
        {
            var str = val.Substring(0, 1).ToCharArray();
            var strCode = (int)str[0];
            if (strCode >= 97)
            {
                var strCaps = strCode - 32;
                return (char)strCaps + val.Substring(1);
            }

            return val;
        }

        /// <summary>
        /// Validates Emails 
        /// </summary>
        /// <param name="val"></param>
        public static bool validateEmail(string val)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match check = emailRegex.Match(val);
            if (check.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Generate hash 
        /// </summary>
        /// <param name="password"></param>
        public static List<byte[]> GenerateHash(string password)
        {
            byte[] passwordSalt, passwordHash;

            // convert password to hash value and generate salt
            using (var hash = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hash.Key;
                passwordHash = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

            var result = new List<byte[]>();
            result.Add(passwordHash);
            result.Add(passwordSalt);

            return result;
        }

        /// <summary>
        /// compare password hash 
        /// </summary>
        /// <param name="passwordSalt"></param>
        /// <param name="passwordHash"></param>
        /// <param name="password"></param>
        public static bool CompareHash(byte[] passwordSalt, byte[] passwordHash, string password)
        {
            using (System.Security.Cryptography.HMACSHA512 hash = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var hashGenerated = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < hashGenerated.Length; i++)
                {
                    if (hashGenerated[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
