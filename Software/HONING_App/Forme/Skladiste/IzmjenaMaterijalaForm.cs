using HONING_App.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HONING_App.Forme.Skladiste
{
    public partial class IzmjenaMaterijalaForm : Form
    {
        Korisnici PrijavljeniKorisnik;
        Materijali_i_sirovine Materijal;
        public IzmjenaMaterijalaForm(Korisnici prijavljeniKorisnik, Materijali_i_sirovine materijal)
        {
            InitializeComponent();
            PrijavljeniKorisnik = prijavljeniKorisnik;
            Materijal = materijal;
            DohvatiPodatke();
        }

        private void DohvatiPodatke()
        {
            TxtNaziv.Text = Materijal.naziv;
            TxtSpecifikacija.Text = Materijal.specifikacija.ToString();
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new EntitiesBaza())
            {
                context.Materijali_i_sirovine.Attach(Materijal);
                Materijal.naziv = TxtNaziv.Text;
                Materijal.specifikacija = TxtSpecifikacija.Text;
                context.SaveChanges();
            }
            this.Close();
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
