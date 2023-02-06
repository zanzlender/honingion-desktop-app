using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentifikacija
{
    /// <summary>
    /// Ova klasa služi za provjeravanje postojanja korisnika u bazi podataka 
    /// za unesene podatke, te validaciju lozinke.
    /// U slučaju da korisnik postoji i lozinka je ispravna, 
    /// metoda vraća id korisnika, u suprotnom vraća nulu;
    /// </summary>
    public static class Autentifikator
    {
        public static int DohvatiKorisnika(string email, string lozinka)
        {
            Korisnicki_racuni trazeniRacun = new Korisnicki_racuni();
            int korisnikID = 0;

            using(var db = new EntitiesDB())
            {
                var korisnik = (from k in db.Korisnici
                               where k.email == email
                               select k).FirstOrDefault();

                if (korisnik == null)
                {
                    return 0;
                }

                korisnikID = korisnik.id;

                var racun = (from r in db.Korisnicki_racuni
                            where r.id == korisnik.korisnickiRacun
                            select r).FirstOrDefault();
                trazeniRacun = racun as Korisnicki_racuni;
            }

            if(trazeniRacun == null || trazeniRacun.lozinka != lozinka)
            {
                return 0;
            }
            else
            {
                return korisnikID;
            }
        }
    }
}
