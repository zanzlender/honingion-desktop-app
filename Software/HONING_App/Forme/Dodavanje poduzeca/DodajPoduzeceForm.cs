using HONING_App.Database;
using HONING_App.Forme.Baza_zaposlenika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HONING_App.Forme.Dodavanje_poduzeca
{
    public partial class DodajPoduzeceForm : Form
    {
        readonly Korisnici prijavljeniKorisnik = new Korisnici();
        public DodajPoduzeceForm(Korisnici korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = TxtNaziv.Text;
            string voditelj = TxtVoditelj.Text;
            string oib = TxtOib.Text;

            using (var db = new EntitiesBaza())
            {
                Poduzeca novoPoduzece = new Poduzeca()
                {
                    naziv = naziv,
                    voditelj = voditelj,
                    oib = oib
                };

                db.Poduzeca.Add(novoPoduzece);
                int uspjesno = db.SaveChanges();

                if(uspjesno != 0)
                {
                    MessageBox.Show("Poduzeće uspješno dodano!\n\nDodaj minimalno jednog administratora za poduzeće " + naziv, "Dodavanje poduzeća", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Greška prilikom stvaranja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Form forma = new DodajNovogZaposlenikaForm(prijavljeniKorisnik);
            forma.ShowDialog();
            this.Close();
        }
    }
}
