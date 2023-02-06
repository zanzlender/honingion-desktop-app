using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;


namespace HONING_App.Exceptions
{
    public static class Validacije
    {
        public static bool ValidirajImePrezimeAdresu(string ime)
        {
            return ime.Length > 1 && ime.Length < 255;
        }

      
        public static bool ValidirajOib(string oib)
        {
            Regex rx = new Regex(@"^\d{11}$");
            return rx.IsMatch(oib);
        }

        public static bool ValidirajEmail(string email)
        {
            Regex rx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return rx.IsMatch(email);
        }

        public static bool ValidirajLozinku(string lozinka)
        {
            return lozinka.Length >= 8;
        }
    }
}
