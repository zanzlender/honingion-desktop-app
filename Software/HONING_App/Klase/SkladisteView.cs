using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HONING_App.Klase
{
    public class SkladisteView
    {
        public int Id { get; set; }
        public string NazivStavke{ get; set; }
        public enum VrstaStavke
        {
            Proizvod,
            Materijal
        }
        public VrstaStavke Vrsta { get; set; }
        public int Kolicina { get; set; }
        public string Zabiljezio { get; set; }

    }
}
