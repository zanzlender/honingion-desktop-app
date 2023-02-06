using HONING_App.Database;
using HONING_App.Klase;
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
    public partial class UnosMaterijalaForm : Form
    {
        public Korisnici PrijavljeniKorisnik;
        public UnosMaterijalaForm(Korisnici prijavljeniKorisnik)
        {
            InitializeComponent();
            PrijavljeniKorisnik = prijavljeniKorisnik;
            
        }

        private void UnosMaterijalaForm_Load(object sender, EventArgs e)
        {
            DohvatiPartnere();
            DohvatiJedinice();
        }

        private void DohvatiJedinice()
        {
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Mjerne_jedinice
                            select n.naziv;
                CmbJedinica.DataSource = query.ToList();
            }
        }

        private void DohvatiPartnere()
        {
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Poslovni_partneri
                            select n.imePoduzeca;
                CmbPartner.DataSource = query.ToList();
            }
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            Mjerne_jedinice jedinica;
            Poslovni_partneri partner;
            string nazivPoduzeca = CmbPartner.SelectedItem.ToString();
            string nazivJedinice = CmbJedinica.SelectedItem.ToString();
            using (var context = new EntitiesBaza())
            {
                
               var queryPartner = from n in context.Poslovni_partneri
                                   where n.imePoduzeca == nazivPoduzeca
                                   select n;
                partner = queryPartner.Single();
                var queryJedinica = from n in context.Mjerne_jedinice
                                    where n.naziv == nazivJedinice
                                    select n;
                jedinica = queryJedinica.Single();
            }

            //spremanje novog materijala
            Materijali_i_sirovine noviMaterijal = new Materijali_i_sirovine()
            {
                naziv = TxtNaziv.Text,
                poslovniPartner = partner.id,
                specifikacija = TxtSpecifikacija.Text,
                poduzece = 1,
                prikazi = false,
                mjernaJedinica = jedinica.id
            };

            using (var context = new EntitiesBaza())
            {
                context.Materijali_i_sirovine.Add(noviMaterijal);
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
