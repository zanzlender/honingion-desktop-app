using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Autentifikacija;
using HONING_App.Exceptions;
using HONING_App.Database;
using Microsoft.Toolkit.Uwp.Notifications;

namespace HONING_App
{
    /// <summary>
    /// Forma za prijavu se otvara čim korisnik pokrene aplikaciju. 
    /// Korisnik unosi e-mail adresu i lozinku te se klikom na gumb Prijava 
    /// poziva metoda DohvatiKorisnika() iz Autentifikator.dll datoteke kako bi 
    /// se provjerila ispravnost unesenih podataka.
    /// Ako postoji korisnik sa unesenim emailom i lozinka je ispravna, 
    /// proslijeđuje se objekt tipa Korisnici u HomeFormu te se ona otvara.
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            TxtEmail.Focus();
        }

        #region UpdateUI
        /// <summary>
        /// Naredna tri delegata služe za ažuriranje LoginForme nakon klikanja 
        /// na gumb Prijava, te primaju parametre koji su potrebni funkcijama
        /// uz koje su delegati povezani, kako bi se pojedini elementi ažurirali. 
        /// </summary>
        public delegate void UpdateProgressBarDelegate();
        public delegate void UpdateAfterErrorDelegate();
        public delegate void HideFormDelegate(int id);

        /// <summary>
        /// Metoda služi za prikazivanje progress bar-a koja će se pozvati 
        /// prilikom klika na gumb prijavi. Želi se poboljšati korisničko 
        /// iskustvo tako da se dodaje indikator učitavanja za vrijeme
        /// dok se izvršava provjeravajne podataka korisnika.
        /// </summary>
        /// <param name="prikazi"></param>
        public void UpdateProgressBar()
        {
            ProgressBar.Visible = true;
        }

        /// <summary>
        /// Metoda služi za sakrivanje progress bar-a. 
        /// Biti će pozvana u slučaju da su uneseni podaci neispravni, 
        /// tako će se korisniku omogučiti ponovo prijavljivanje.
        /// </summary>
        /// <param name="text"></param>
        public void UpdateAfterError()
        {
            TxtEmail.Focus();
            ProgressBar.Visible = false;
        }

        /// <summary>
        /// Metoda služi za prikazivanje nove forme, HomeForme,
        /// i sakrivanja trenutne, LoginForme.
        /// </summary>
        /// <param name="form"></param>
        public void HideForm(int id)
        {
            Form homeForm = new Forme.Home.HomeForm(id);
            this.Hide();
            homeForm.ShowDialog();
            this.Close();
        }
        #endregion

        /// <summary>
        /// Ovaj event handler se poziva klikom na gumb prijavi.
        /// - Dretva t1 služi za ažuriranje forme, tj. pokretanja progress bar-a.
        /// - Dretva t2 služi za provjeru ispravnog unosa od strane korisnika, pomoću
        /// metode DohvatiKorisnika(), kojoj se proslijeđuju uneseni podaci
        /// - Dretva t3 služi za pokretanje HomeForme i zatvaranje Login forme, izvršava
        /// se u slučaju kada je vraćeno true od metode DohvatiKorisnika(), što ukazuje na ispravan unos.
        /// - Dretva t4 služi za ažuiranje forme u slučaju da su uneseni podaci nesipravni
        /// i korisnik ponovno mora unijeti podatke.
        /// 
        /// U slučaju da je vraćeni korisnik jednak null, ispisuje se poruka o grešci i 
        /// zahtjeva se ponovni unos.
        /// </summary>
        private void BtnPrijava_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() =>
            {
                Invoke(new UpdateProgressBarDelegate(UpdateProgressBar));
            });

            Thread t2 = new Thread(() => 
            {
                string email = TxtEmail.Text.ToString();
                string lozinka = TxtLozinka.Text.ToString();

                int dohvaceniID = Autentifikator.DohvatiKorisnika(email, lozinka);

                if (dohvaceniID != 0)
                {
                    ToastContentBuilder s = new ToastContentBuilder();
                    s
                        .AddText("Honingion notifikacija")
                        .AddText("Uspješna prijava! Dobrodošli! ")
                        .Show(toast => {
                            toast.ExpirationTime = DateTime.Now.AddSeconds(20);
                        });

                    s.GetToastContent();
                    Thread t3 = new Thread(() => 
                    {
                        Invoke(new HideFormDelegate(HideForm), dohvaceniID);
                    });
                    t3.Start();
                }
                else
                {
                    new ToastContentBuilder()
                        .AddText("Honingion notifikacija")
                        .AddText("Unesen e-mail ili lozinka su neispravni")
                        .Show(toast => {
                            toast.ExpirationTime = DateTime.Now.AddSeconds(20);
                        });

                    Thread t4 = new Thread(() => 
                    {
                        Invoke(new UpdateAfterErrorDelegate(UpdateAfterError));
                    });
                    t4.Start();
                }
            });

            t1.Start();
            t2.Start();
        }


        #region Validacija
        /// <summary>
        /// Ovaj event handler provjerava da li su uneseni podaci u tekstualni
        /// okvir za email ispravni, odnosno da li je email ispravnog formata.
        /// U slučaju da nije panel u koji je tekstualni okvir smješten mijenja boju
        /// i pojavljuje se tooltip kako bi unos trebao izgledati.
        /// </summary>
        
        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Validacije.ValidirajEmail(TxtEmail.Text))
            {
                panel3.BackColor = Color.FromArgb(255, 162, 156);
                TxtEmail.BackColor = Color.FromArgb(255, 162, 156);
                this.errorProvider1.SetError(TxtEmail, "E-mail mora biti u formatu korisnickoime@honning-doo.com");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Ovaj event handler se izvršava nakon što je korisnik unio ispravne 
        /// podatke u tekstualni okvir za email i kliknuo van njega. 
        /// U tom slučaju izgled forme se vraća na početne postavke.
        /// </summary>
        private void TxtEmail_Validated(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            TxtEmail.BackColor = Color.White;
            this.errorProvider1.SetError(TxtEmail, "");
            BtnPrijava.Enabled = true;
        }

        #endregion


        private void CheckBoxPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            TxtLozinka.PasswordChar = CheckBoxPrikaziLozinku.Checked ? '\0' : '*';
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void IconIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
