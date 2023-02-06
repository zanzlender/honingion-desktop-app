using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HONING_App.Klase
{
    class SviGodisnjiOdmoriView
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string ImeVoditelja { get; set; }
        public string PrezimeVoditelja { get; set; }
        public bool? Odobreno { get; set; }

    }
}
