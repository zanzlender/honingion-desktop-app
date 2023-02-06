using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HONING_App.Database;

namespace HONING_App.Forme.Godišnji_odmori
{
    public partial class ZahtjevGodisnjiOdmorForm : Form
    {
        readonly private Korisnici PrijavljeniKorisnik;
        public ZahtjevGodisnjiOdmorForm(Korisnici prijavljeniKorisnik)
        {
            InitializeComponent();
            PrijavljeniKorisnik = prijavljeniKorisnik;
            LblPodaciKorisnika.Text = PrijavljeniKorisnik.ime + " " + PrijavljeniKorisnik.prezime;
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPosalji_Click(object sender, EventArgs e)
        {
            int Korisnik = PrijavljeniKorisnik.id;
            using (var context = new EntitiesBaza())
            {
                Godisnji_odmori noviGodisnjiOdmor = new Godisnji_odmori()
                {
                    korisnik = PrijavljeniKorisnik.id,
                    datumOd = DtpDatumOd.Value,
                    datumDo = DtpDatumDo.Value
                };
                context.Godisnji_odmori.Add(noviGodisnjiOdmor);
                int uspjesno = context.SaveChanges();
            }
            this.Close();
        }

        
    }
}
