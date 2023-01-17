using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extensions
{
    public static class eMail
    {
        public static string CreateEmail(this string str, int yearOfBirth, string domain)
        {

            return $"{str.Replace(" ", "").ToLower()}{yearOfBirth}@{domain}";
        }
    }
}
