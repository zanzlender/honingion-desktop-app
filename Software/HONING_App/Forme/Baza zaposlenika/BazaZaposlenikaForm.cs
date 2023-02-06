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

namespace HONING_App.Forme.Baza_zaposlenika
{
    public partial class BazaZaposlenikaForm : Form
    {
        readonly private Korisnici prijavljeniKorisnik = new Korisnici();
        public BazaZaposlenikaForm(Korisnici korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void BazaZaposlenikaForm_Load(object sender, EventArgs e)
        {
            LblIspisCekanja.Visible = true;
            PozoviOsvjetiTablicuAsync();
        }

        /// <summary>
        /// Metoda dohvaća sve zaposlenike iz baze podataka
        /// Ako je prijavljeni korisnik superadministrator, dohvaća sve zaposlenike iz svih poduzeća
        /// Ako je prijavljeni korisnik administrator, dohvaća sve zaposlenike tog poduzeća
        /// </summary>
        /// <returns></returns>
        private List<Korisnici> DohvatiZaposlenike()
        {
            List<Korisnici> dohvaceniKorisnici = new List<Korisnici>();
            using (var db = new EntitiesBaza())
            {
                if(prijavljeniKorisnik.uloga == 1)
                {
                    var korisnici = (from k in db.Korisnici
                                     select k as Korisnici).ToList();
                    dohvaceniKorisnici = new List<Korisnici>(korisnici);
                }
                if(prijavljeniKorisnik.uloga == 2)
                {
                    var korisnici = (from k in db.Korisnici
                                     where k.poduzece == prijavljeniKorisnik.poduzece
                                     select k as Korisnici).ToList();
                    dohvaceniKorisnici = new List<Korisnici>(korisnici);
                }
            }
            return dohvaceniKorisnici;
        }

        private Task<List<Korisnici>> OsvjeziTablicuAsync()
        {
            return Task.Factory.StartNew(() => DohvatiZaposlenike());
        }

        private async void PozoviOsvjetiTablicuAsync()
        {
            //System.Threading.Thread.Sleep(2000);
            DgvZaposlenici.DataSource = await OsvjeziTablicuAsync();
            DgvZaposlenici.Columns["Gradovi"].Visible = false;
            DgvZaposlenici.Columns["Korisnicki_racuni"].Visible = false;
            DgvZaposlenici.Columns["Odjeli"].Visible = false;
            DgvZaposlenici.Columns["Poduzeca"].Visible = false;
            DgvZaposlenici.Columns["Vrste_korisnika"].Visible = false;
            LblIspisCekanja.Visible = false;
        }

        private Korisnici DohvatiOdabranogKorisnika()
        {
            Korisnici odabraniKorisnik = DgvZaposlenici.CurrentRow.DataBoundItem as Korisnici;
            return odabraniKorisnik;
        }

        private void BtnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            Form forma = new DodajNovogZaposlenikaForm(prijavljeniKorisnik);
            forma.ShowDialog();
            PozoviOsvjetiTablicuAsync();
        }

        private void BtnIzmijeniZaposlenika_Click(object sender, EventArgs e)
        {
            if(DohvatiOdabranogKorisnika() != null)
            {
                Form forma = new IzmijeniZaposlenikaForm(DohvatiOdabranogKorisnika(), prijavljeniKorisnik);
                forma.ShowDialog();
                PozoviOsvjetiTablicuAsync();
            }
        }

        private void DgvZaposlenici_SelectionChanged(object sender, EventArgs e)
        {
            BtnIzmijeniZaposlenika.Enabled = true;
            BtnObrisi.Enabled = true;
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            int uspjesno = 0;
            DialogResult odgovor = MessageBox.Show("Ova akcija će trajno obrisati korisnika!\n\n Želite li nastaviti?",
                                   "Brisanje korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (odgovor == DialogResult.Yes)
            {
                Korisnici odabraniKorisnik = DohvatiOdabranogKorisnika();
                using (var db = new EntitiesBaza())
                {
                    var korisnik = (from k in db.Korisnici
                                          where k.id == odabraniKorisnik.id
                                          select k).FirstOrDefault();
                    odabraniKorisnik = korisnik;
                    db.Korisnici.Attach(odabraniKorisnik);
                    db.Korisnici.Remove(odabraniKorisnik);
                    uspjesno = db.SaveChanges();
                }
                if (uspjesno != 0)
                {
                    MessageBox.Show("Korisnik je obrisan", "Brisanje korisnika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PozoviOsvjetiTablicuAsync();
                }
            }
        }
    }
}
