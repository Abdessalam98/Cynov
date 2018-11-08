using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cynov
{
    class Validator
    {
        public static bool IsBetween(string str, int minLength, int maxLength)
        {
            return str.Length >= minLength && str.Length <= maxLength;
        }

        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }

        public static bool IsValidPass(string pass, int minLength)
        {
            return pass != "" && pass.Length >= minLength;
        }

    }
}
