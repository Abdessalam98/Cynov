using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cynov
{
    class Utils
    {
        public static string EncodePassword(string passText)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var rfc2898 = new Rfc2898DeriveBytes(passText, salt, 12000);
            byte[] hash = rfc2898.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPassword = Convert.ToBase64String(hashBytes);

            return savedPassword;
        } 

        public static bool DecodePassword(string savedPassword, string passText)
        {
            bool isValid = true;

            byte[] hashBytesCheck = Convert.FromBase64String(savedPassword);
            byte[] saltCheck = new byte[16];

            Array.Copy(hashBytesCheck, 0, saltCheck, 0, 16);

            var rfc2898Check = new Rfc2898DeriveBytes(passText, saltCheck, 12000);
            byte[] hashCheck = rfc2898Check.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if(hashBytesCheck[i+16] != hashCheck[i])
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        public static DateTime ConvertToDateTime(string strDate)
        {
            string[] splittedDate = strDate.Split('-');
            string[] fullDate = splittedDate[0].Split('/');
            string[] fullTime = splittedDate[1].Split(':');



            return new DateTime(int.Parse(fullDate[2]), int.Parse(fullDate[1]), int.Parse(fullDate[0]),
                int.Parse(fullTime[0]), int.Parse(fullTime[1]), 0);
        }
    }
}
