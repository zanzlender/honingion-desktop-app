using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorGodisnjeg
{
    public static class KalkulatorGodisnjeg
    {
        public static Dictionary<string, int> IzracunajGodisnje(int idKorisnika)
        {
            Dictionary<string, int> izracunatiSlobodniDani = new Dictionary<string, int>();
            izracunatiSlobodniDani.Clear();
            List<Slobodni_dani> slobodniDaniLista = DohvatiSlobodneDane(idKorisnika);

            foreach (Slobodni_dani item in slobodniDaniLista)
            {
                izracunatiSlobodniDani.Add("ukupno", item.slobodniDani);
                izracunatiSlobodniDani.Add("iskoristeno", item.iskoristeniDani);
                izracunatiSlobodniDani.Add("preostalo", item.slobodniDani - item.iskoristeniDani);
            }

            return izracunatiSlobodniDani;
        }

        private static List<Slobodni_dani> DohvatiSlobodneDane(int idKorisnika)
        {
            List<Slobodni_dani> slobodniDaniLista = new List<Slobodni_dani>();

            using (var db = new Entities())
            {
                var dani = from s in db.Slobodni_dani
                           where s.korisnik == idKorisnika
                           select s;

                slobodniDaniLista = dani.ToList();
            }

            return slobodniDaniLista;
        }
    }
}
