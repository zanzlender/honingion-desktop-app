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
using HONING_App.Exceptions;
using HONING_App.Klase;

namespace HONING_App.Forme.Baza_zaposlenika
{
    public partial class DodajNovogZaposlenikaForm : Form
    {
        readonly Korisnici prijavljeniKorisnik = new Korisnici();
        List<Odjeli> listaOdjela = new List<Odjeli>();
        public DodajNovogZaposlenikaForm(Korisnici korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void DodajNovogZaposlenikaForm_Load(object sender, EventArgs e)
        {
            //Ovo znači da je administrator
            if (prijavljeniKorisnik.poduzece != null)
            {
                PanelPoduzece.Enabled = false;
                PozoviOsvjezavanjeListi(prijavljeniKorisnik);
            }
            else
            {
                PozoviOsvjezavanjeListi();
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGenerirajLozinku_Click(object sender, EventArgs e)
        {
            TxtLozinka.Text = GeneratorLozinki.GenerirajLozinku();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            string ime = TxtIme.Text;
            string prezime = TxtPrezime.Text;
            string oib = TxtOib.Text;
            string email = TxtEmail.Text;
            string broj = TxtBroj.Text;
            string adresa = TxtAdresa.Text;
            Gradovi odabraniGrad = CboxGradovi.SelectedItem as Gradovi;
            int mjesto = odabraniGrad.id;
            Poduzeca odabranoPoduzece = CboxPoduzeca.SelectedItem as Poduzeca;
            int poduzece = odabranoPoduzece.id;
            Vrste_korisnika odabranaUloga = CboxUloge.SelectedItem as Vrste_korisnika;
            int uloga = odabranaUloga.id;
            Odjeli odabraniOdjel = CboxOdjeli.SelectedItem as Odjeli;
            int odjel = odabraniOdjel.id;
            string lozinka = TxtLozinka.Text;

            using(var db = new EntitiesBaza())
            {
                Korisnicki_racuni noviRacun = new Korisnicki_racuni()
                {
                    lozinka = lozinka
                };

                db.Korisnicki_racuni.Add(noviRacun);
                int uspjesno = db.SaveChanges();

                Korisnicki_racuni racun = (from k in db.Korisnicki_racuni
                                           where k.lozinka == lozinka
                                           select k).First();

                if (uspjesno != 0)
                {
                    Korisnici noviKorisnik = new Korisnici()
                    {
                        ime = ime,
                        prezime = prezime,
                        oib = oib,
                        email = email,
                        kontaktBroj = broj,
                        adresa = adresa,
                        prebivaliste = mjesto,
                        poduzece = poduzece,
                        uloga = uloga,
                        odjel = odjel,
                        korisnickiRacun = racun.id
                    };

                    db.Korisnici.Add(noviKorisnik);
                    db.SaveChanges();
                    MessageBox.Show("Korisnik uspješno dodan!", "Dodavanje korisnika", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Greška prilikom stvaranja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Close();
        }

        #region Dohvaćanje podataka iz baze
        private async void PozoviOsvjezavanjeListi(Korisnici korisnik = null)
        {
            CboxGradovi.DataSource = await DohvatiGradoveAsync();
            CboxGradovi.SelectedItem = null;

            if (korisnik == null)
            {
                CboxPoduzeca.DataSource = await DohvatiPoduzecaAsync();
                CboxPoduzeca.SelectedItem = null;
            }
            else
            {
                CboxPoduzeca.DataSource = await DohvatiPoduzecaAsync();
                CboxPoduzeca.SelectedItem = prijavljeniKorisnik.poduzece;
            }
            listaOdjela = await DohvatiOdjeleAsync(korisnik);
            CboxOdjeli.DataSource = listaOdjela;
            CboxOdjeli.SelectedItem = null;
            CboxUloge.DataSource = await DohvatiUlogeAsync(korisnik);
            CboxUloge.SelectedItem = null;
        }
        private List<Gradovi> DohvatiGradove()
        {
            using (var db = new EntitiesBaza())
            {
                var gradovi = from g in db.Gradovi
                              select g;
                return gradovi.ToList();
            }
        }
        private Task<List<Gradovi>> DohvatiGradoveAsync()
        {
            return Task.Factory.StartNew(() => DohvatiGradove());
        }


        private List<Poduzeca> DohvatiPoduzeca()
        {
            using (var db = new EntitiesBaza())
            {
                var poduzeca = from g in db.Poduzeca
                               select g;
                return poduzeca.ToList();
            }
        }
        private Task<List<Poduzeca>> DohvatiPoduzecaAsync()
        {
            return Task.Factory.StartNew(() => DohvatiPoduzeca());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="korisnik"></param>
        /// <returns></returns>
        private List<Odjeli> DohvatiOdjele(Korisnici korisnik = null)
        {
            using (var db = new EntitiesBaza())
            {
                if (korisnik == null)
                {
                    var odjeli = from g in db.Odjeli
                                 select g;
                    return odjeli.ToList();
                }
                else
                {
                    var odjeli = from g in db.Odjeli
                                 where g.poduzece == korisnik.poduzece
                                 select g;
                    return odjeli.ToList();
                }
            }
        }
        private Task<List<Odjeli>> DohvatiOdjeleAsync(Korisnici korisnik = null)
        {
            return Task.Factory.StartNew(() => DohvatiOdjele(korisnik));
        }


        private List<Vrste_korisnika> DohvatiUloge(Korisnici korisnik = null)
        {
            using (var db = new EntitiesBaza())
            {
                if (korisnik == null)
                {
                    var uloge = from g in db.Vrste_korisnika
                                select g;
                    return uloge.ToList();
                }
                else
                {
                    var uloge = from g in db.Vrste_korisnika
                                where g.naziv != "Superadministrator"
                                select g;
                    return uloge.ToList();
                }
            }
        }
        private Task<List<Vrste_korisnika>> DohvatiUlogeAsync(Korisnici korisnik = null)
        {
            return Task.Factory.StartNew(() => DohvatiUloge(korisnik));
        }

        #endregion

        #region Validacija podataka
        private void TxtIme_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacije.ValidirajImePrezimeAdresu(TxtIme.Text))
            {
                PanelIme.BackColor = Color.FromArgb(255, 162, 156);
                TxtIme.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(TxtIme, "Polje Ime ne smije biti prazno.");
                e.Cancel = true;
            }
        }

        private void TxtIme_Validated(object sender, EventArgs e)
        {
            PanelIme.BackColor = Color.White;
            TxtIme.BackColor = Color.White;
            this.errorProvider1.SetError(TxtIme, "");
        }

        private void TxtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacije.ValidirajImePrezimeAdresu(TxtPrezime.Text))
            {
                PanelPrezime.BackColor = Color.FromArgb(255, 162, 156);
                TxtPrezime.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(TxtPrezime, "Polje Prezime ne smije biti prazno.");
                e.Cancel = true;
            }
        }
        private void TxtPrezime_Validated(object sender, EventArgs e)
        {
            PanelPrezime.BackColor = Color.White;
            TxtPrezime.BackColor = Color.White;
            this.errorProvider1.SetError(TxtPrezime, "");
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacije.ValidirajEmail(TxtEmail.Text))
            {
                PanelEmail.BackColor = Color.FromArgb(255, 162, 156);
                TxtEmail.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(TxtEmail, "E-mail mora biti u formatu korisnickoime@honning-doo.com");
                e.Cancel = true;
            }
        }

        private void TxtEmail_Validated(object sender, EventArgs e)
        {
            PanelEmail.BackColor = Color.White;
            TxtEmail.BackColor = Color.White;
            this.errorProvider1.SetError(TxtEmail, "");
        }

        private void TxtBroj_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacije.ValidirajImePrezimeAdresu(TxtBroj.Text))
            {
                PanelBroj.BackColor = Color.FromArgb(255, 162, 156);
                TxtBroj.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(TxtBroj, "Polje Prezime ne smije biti prazno.");
                e.Cancel = true;
            }
        }
        private void TxtBroj_Validated(object sender, EventArgs e)
        {
            PanelBroj.BackColor = Color.White;
            TxtBroj.BackColor = Color.White;
            this.errorProvider1.SetError(TxtBroj, "");
        }

        private void TxtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacije.ValidirajImePrezimeAdresu(TxtAdresa.Text))
            {
                PanelAdresa.BackColor = Color.FromArgb(255, 162, 156);
                TxtAdresa.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(TxtAdresa, "Polje Adresa ne smije biti prazno!");
                e.Cancel = true;
            }
        }

        private void TxtAdresa_Validated(object sender, EventArgs e)
        {
            PanelAdresa.BackColor = Color.White;
            TxtAdresa.BackColor = Color.White;
            this.errorProvider1.SetError(TxtAdresa, "");
        }

        private void TxtOib_Validating(object sender, CancelEventArgs e)
        {
            
            if (!Validacije.ValidirajOib(TxtOib.Text) )
            {
                PanelOib.BackColor = Color.FromArgb(255, 162, 156);
                TxtOib.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(TxtOib, "OIB mora sadržavati točno 11 znakova!");
                e.Cancel = true;
            }
        }

        private void TxtOib_Validated(object sender, EventArgs e)
        {
            PanelOib.BackColor = Color.White;
            TxtOib.BackColor = Color.White;
            this.errorProvider1.SetError(TxtOib, "");
        }

        private void CboxGradovi_Validating(object sender, CancelEventArgs e)
        {
            if (CboxGradovi.SelectedItem == null)
            {
                PanelMjesto.BackColor = Color.FromArgb(255, 162, 156);
                CboxGradovi.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(CboxGradovi, "OIB mora sadržavati točno 11 znakova!");
                e.Cancel = true;
            }
        }

        private void CboxGradovi_Validated(object sender, EventArgs e)
        {
            PanelMjesto.BackColor = Color.White;
            CboxGradovi.BackColor = Color.White;
            this.errorProvider1.SetError(CboxGradovi, "");
        }

        private void CboxPoduzeca_Validating(object sender, CancelEventArgs e)
        {
            if (CboxPoduzeca.SelectedItem == null)
            {
                PanelPoduzece.BackColor = Color.FromArgb(255, 162, 156);
                CboxPoduzeca.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(CboxPoduzeca, "OIB mora sadržavati točno 11 znakova!");
                e.Cancel = true;
            }
        }

        private void CboxPoduzeca_Validated(object sender, EventArgs e)
        {
            PanelPoduzece.BackColor = Color.White;
            CboxPoduzeca.BackColor = Color.White;
            this.errorProvider1.SetError(CboxPoduzeca, "");
        }

        private void CboxUloge_Validating(object sender, CancelEventArgs e)
        {
            if (CboxUloge.SelectedItem == null)
            {
                PanelUloga.BackColor = Color.FromArgb(255, 162, 156);
                CboxUloge.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(CboxUloge, "OIB mora sadržavati točno 11 znakova!");
                e.Cancel = true;
            }
        }

        private void CboxUloge_Validated(object sender, EventArgs e)
        {
            PanelUloga.BackColor = Color.White;
            CboxUloge.BackColor = Color.White;
            this.errorProvider1.SetError(CboxUloge, "");
        }

        private void CboxOdjeli_Validating(object sender, CancelEventArgs e)
        {
            if (CboxOdjeli.SelectedItem == null)
            {
                PanelOdjel.BackColor = Color.FromArgb(255, 162, 156);
                CboxOdjeli.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(CboxOdjeli, "OIB mora sadržavati točno 11 znakova!");
                e.Cancel = true;
            }
        }

        private void CboxOdjeli_Validated(object sender, EventArgs e)
        {
            PanelOdjel.BackColor = Color.White;
            CboxOdjeli.BackColor = Color.White;
            this.errorProvider1.SetError(CboxOdjeli, "");
        }

        private void TxtLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacije.ValidirajLozinku(TxtLozinka.Text))
            {
                PanelLozinka.BackColor = Color.FromArgb(255, 162, 156);
                TxtLozinka.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(TxtLozinka, "OIB mora sadržavati točno 11 znakova!");
                e.Cancel = true;
            }
        }

        private void TxtLozinka_Validated(object sender, EventArgs e)
        {
            PanelLozinka.BackColor = Color.White;
            TxtLozinka.BackColor = Color.White;
            this.errorProvider1.SetError(TxtLozinka, "");
        }

        #endregion

        private void CboxPoduzeca_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltrirajOdjele();
        }

        private void FiltrirajOdjele()
        {
            if(prijavljeniKorisnik.uloga == 1)
            {
                CboxOdjeli.DataSource = listaOdjela.FindAll(x => x.poduzece == (CboxPoduzeca.SelectedItem as Poduzeca).id);
            }
        }
    }
}
