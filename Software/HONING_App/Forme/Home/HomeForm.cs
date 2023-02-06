using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using HONING_App.Database;
using Microsoft.Toolkit.Uwp.Notifications;
using System.IO;

namespace HONING_App.Forme.Home
{
    /// <summary>
    /// Ova forma služi kao Parent forma u kojoj će se otvarati sve ostale forme,
    /// unutar panela PanelParent, i pomoću koje će se pristupati svim ostalim formama.
    /// </summary>
    public partial class HomeForm : Form
    {
        readonly Korisnici prijavljeniKorisnik = new Korisnici();
        bool izadi = false;
        
        /// <summary>
        /// Ovoj formi se proslijeđuje id prijavljenog korisnika,
        /// kako bi se mogli preuzeti svi podaci o korisniku iz baze.
        /// Ovisno o ulozi prijavljenog korisnika, postavljaju se gumbovi
        /// za forme kojima smije pristupiti.
        /// </summary>
        /// <param name="korisnikID"></param>
        public HomeForm(int korisnikID)
        {
            InitializeComponent();
            using (var db = new EntitiesBaza())
            {
                prijavljeniKorisnik = db.Korisnici.Find(korisnikID);
                TxtUloga.Text = db.Vrste_korisnika.Find(prijavljeniKorisnik.uloga).naziv.ToUpper();
                TxtUloga.SelectAll();
                TxtUloga.SelectionAlignment = HorizontalAlignment.Center;
                TxtImePrezime.Text = (prijavljeniKorisnik.ime + " " + prijavljeniKorisnik.prezime).ToUpper();
                TxtImePrezime.SelectAll();
                TxtImePrezime.SelectionAlignment = HorizontalAlignment.Center;
            }
            //Superadministrator
            if(prijavljeniKorisnik.uloga == 1)
            {
                BtnDodajPoduzece.Visible = true;
                BtnBazaZaposlenika.Visible = true;
                BtnLogut.Visible = true;

                AnimirajGumb(BtnBazaZaposlenika, RGBColors.crvena);
                Form forma = new Baza_zaposlenika.BazaZaposlenikaForm(prijavljeniKorisnik);
                OtvoriFormu(forma);
            }
            // Administrator
            else if (prijavljeniKorisnik.uloga == 2)
            {
                BtnNovosti.Visible = true;
                BtnRaspored.Visible = true;
                BtnGodisnji.Visible = true;
                BtnProdaja.Visible = true;
                BtnSkladiste.Visible = true;
                BtnStatistika.Visible = true;
                BtnBazaZaposlenika.Visible = true;
                BtnLogut.Visible = true;

                AnimirajGumb(BtnNovosti, RGBColors.crvena);
                Form forma = new Novosti.NovostiObavijestiForm();
                OtvoriFormu(forma);

            }
            // Voditelj prodaje
            else if(prijavljeniKorisnik.uloga == 3 && prijavljeniKorisnik.odjel == 1){
                BtnNovosti.Visible = true;
                BtnRaspored.Visible = true;
                BtnGodisnji.Visible = true;
                BtnProdaja.Visible = true;
                BtnSkladiste.Visible = true;
                BtnStatistika.Visible = true;
          //    BtnBazaZaposlenika.Visible = true;
                BtnLogut.Visible = true;

                AnimirajGumb(BtnNovosti, RGBColors.crvena);
                Form forma = new Novosti.NovostiObavijestiForm();
                OtvoriFormu(forma);
            }
            // Voditelj skladišta
            else if (prijavljeniKorisnik.uloga == 3 && prijavljeniKorisnik.odjel == 3)
            {
                BtnNovosti.Visible = true;
                BtnRaspored.Visible = true;
                BtnGodisnji.Visible = true;
                BtnProdaja.Visible = true;
                BtnSkladiste.Visible = true;
                BtnStatistika.Visible = true;
          //    BtnBazaZaposlenika.Visible = true;
                BtnLogut.Visible = true;

                AnimirajGumb(BtnNovosti, RGBColors.crvena);
                Form forma = new Novosti.NovostiObavijestiForm();
                OtvoriFormu(forma);
            }

            // Korisnik - prodaje 
            else if (prijavljeniKorisnik.uloga == 4 && prijavljeniKorisnik.odjel == 1){
                BtnNovosti.Visible = true;
                BtnRaspored.Visible = true;
                BtnGodisnji.Visible = true;
                BtnProdaja.Visible = true;
                BtnLogut.Visible = true;

                AnimirajGumb(BtnNovosti, RGBColors.crvena);
                Form forma = new Novosti.NovostiObavijestiForm();
                OtvoriFormu(forma);
            }

            // Korisnik - skladišta 
            else if (prijavljeniKorisnik.uloga == 4 && prijavljeniKorisnik.odjel == 3)
            {
                BtnNovosti.Visible = true;
                BtnRaspored.Visible = true;
                BtnGodisnji.Visible = true;
                BtnSkladiste.Visible = true;
                BtnLogut.Visible = true;

                AnimirajGumb(BtnNovosti, RGBColors.crvena);
                Form forma = new Novosti.NovostiObavijestiForm();
                OtvoriFormu(forma);
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }


        #region Aktivacija gumbova u izborniku

        private void BtnNovosti_Click(object sender, EventArgs e)
        {
            AnimirajGumb(sender, RGBColors.crvena);
            Form forma = new Novosti.NovostiObavijestiForm();
            OtvoriFormu(forma);
        }

        private void BtnRaspored_Click(object sender, EventArgs e)
        {
            AnimirajGumb(sender, RGBColors.crvena);
        }

        private void BtnGodisnji_Click(object sender, EventArgs e)
        {
            AnimirajGumb(sender, RGBColors.crvena); 
            Form forma = new Godišnji_odmori.GodisnjiOdmoriForm(prijavljeniKorisnik);
            OtvoriFormu(forma);

        }

        private void BtnProdaja_Click(object sender, EventArgs e)
        {
            AnimirajGumb(sender, RGBColors.crvena);
        }

        private void BtnSkladiste_Click(object sender, EventArgs e)
        {
            AnimirajGumb(sender, RGBColors.crvena);
            Form forma = new Skladiste.SkladisteForm(prijavljeniKorisnik);
            OtvoriFormu(forma);
        }

        private void BtnStatistika_Click(object sender, EventArgs e)
        {
            AnimirajGumb(sender, RGBColors.crvena);
        }

        private void BtnBazaZaposlenika_Click(object sender, EventArgs e)
        {
            AnimirajGumb(sender, RGBColors.crvena);
            Form forma = new Baza_zaposlenika.BazaZaposlenikaForm(prijavljeniKorisnik);
            OtvoriFormu(forma);
        }

        private void BtnUpravljanjeUlogama_Click(object sender, EventArgs e)
        {
            AnimirajGumb(sender, RGBColors.crvena);
        }

        private void BtnDodajPoduzece_Click(object sender, EventArgs e)
        {
            AnimirajGumb(sender, RGBColors.crvena);
            Form forma = new Dodavanje_poduzeca.BazaPoduzecaForm(prijavljeniKorisnik);
            OtvoriFormu(forma);
        }

        /// <summary>
        /// Prilikom odjave kreira se Windows Toast notifikacija koja
        /// pita korisnika da li se stvarno želi odjaviti.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogut_Click(object sender, EventArgs e)
        {
            Form forma = new LoginForm();
            /*
            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                // Obtain the arguments from the notification
                ToastArguments args = ToastArguments.Parse(toastArgs.Argument);
                if (args.FirstOrDefault(x => x.Key == "potvrda").Value == "Da")
                {

                    Form currentForm = Application.OpenForms[Application.OpenForms.Count - 1];
                    Task.Factory.StartNew(() => { this.Hide(); forma.ShowDialog(); this.Close(); }).ContinueWith(task => Console.Write("HI"), TaskScheduler.FromCurrentSynchronizationContext());
                    /*
                    currentForm.BeginInvoke(new Action(() => currentForm.Hide()));
                    forma.BeginInvoke(new Action(() => currentForm.ShowDialog()));
                    currentForm.BeginInvoke(new Action(() => currentForm.Close()));
                    
                }
            };
            ToastContentBuilder s = new ToastContentBuilder();
                    s
                        .AddText("Honingion notifikacija")
                        .AddText("Želite li se odjaviti?")
                        .AddButton(new ToastButton()
                            .SetContent("Da")
                            .AddArgument("potvrda", "Da"))
                        .AddButton(new ToastButton()
                            .SetContent("Ne")
                            .AddArgument("nepotvrda", "Ne"))
                        .Show(toast => {
                            toast.ExpirationTime = DateTime.Now.AddSeconds(30);
                        });
            s.GetToastContent();
            */
             
            
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da se želite odjaviti?", "Odjava", MessageBoxButtons.YesNo);
            
            if(izadi == true)
            {
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
            if ( dialogResult == DialogResult.Yes)
            {
                this.Hide();
                forma.ShowDialog();
                this.Close();
            }
        }

        #endregion


        #region Animacija gumbova u izborniku

        public Form activeForm = null;
        private void OtvoriFormu(Form novaForma)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = novaForma;
            novaForma.Dock = DockStyle.Fill;
            novaForma.TopLevel = false;
            novaForma.FormBorderStyle = FormBorderStyle.None;
            PanelParent.Controls.Add(novaForma);
            PanelParent.Tag = novaForma;
            novaForma.BringToFront();
            novaForma.Show();
        }

        private struct RGBColors
        {
            public static Color crvena = Color.FromArgb(252, 83, 71);
            public static Color svijetloSiva = Color.FromArgb(235, 235, 235);
        }

        private IconButton currentBtn;

        /// <summary>
        /// Ova metoda služi za animaciju gumba.
        /// Poziva se prilikom klika na gumb, kako bi se naznačilo da se korisnik
        /// trenutno nalazi na određenoj stranici.
        /// Prvo se deaktivira trenutni gumb, a zatim se provjerava se koji gumb 
        /// poziva event handler, taj gumb se aktivira. 
        /// </summary>
        private void AnimirajGumb(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DeaktivirajGumb();
                currentBtn = (IconButton)senderBtn;
                Transition tranzicijaGumbova = new Transition(new TransitionType_EaseInEaseOut(150));
                tranzicijaGumbova.add(currentBtn, "BackColor", RGBColors.svijetloSiva);
                tranzicijaGumbova.add(currentBtn, "ForeColor", color);
                tranzicijaGumbova.add(currentBtn, "IconColor", color);
                tranzicijaGumbova.run();
                currentBtn.Padding = new Padding(30, 0, 0, 0);
            }
        }
        
        /// <summary>
        /// Ova metoda služi za animaciju gumba, vraća izgled gumba u početno stanje.
        /// Pozivati će se prilikom klikanja na neki drugi gumb.
        /// </summary>
        private void DeaktivirajGumb()
        {
            if (currentBtn != null)
            {
                Transition tranzicijaGumbova = new Transition(new TransitionType_EaseInEaseOut(150));
                tranzicijaGumbova.add(currentBtn, "BackColor", Color.WhiteSmoke);
                tranzicijaGumbova.add(currentBtn, "ForeColor", Color.Gray);
                tranzicijaGumbova.add(currentBtn, "IconColor", Color.Gray);
                tranzicijaGumbova.run();
                currentBtn.Padding = new Padding(20, 0, 0, 0);
            }
        }


        #endregion


        private void HomeForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string helpLocation = Path.Combine(Environment.CurrentDirectory, "HONINGION_Help.chm");
            Help.ShowHelp(this, helpLocation);
        }
    }
}
