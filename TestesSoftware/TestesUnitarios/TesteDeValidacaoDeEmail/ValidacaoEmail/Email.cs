using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoEmail
{
    public static class Email
    {
        public static bool ValidarEmail(string email)
        {
            var split = email.Split("@");
            var contains = split[1].Contains(".");

            return contains;
        }
    }
}
