using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HONING_App.Klase
{
    public static class GeneratorLozinki
    {
        public static string GenerirajLozinku()
        {
            const string moguciZnakovi = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            StringBuilder lozinka = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                lozinka.Append(moguciZnakovi[rnd.Next(moguciZnakovi.Length)]);
            }
            return lozinka.ToString();
            
        }
    }

}
