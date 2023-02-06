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
    public partial class SkladisteForm : Form
    {
        readonly private Korisnici PrijavljeniKorisnik;
        public SkladisteForm(Korisnici prijavljeniKorisnik)
        {
            InitializeComponent();
            PrijavljeniKorisnik = prijavljeniKorisnik;
            ProvjeraKorisnika();
            DohvatiNaziveStavki();
        }

        private void ProvjeraKorisnika()
        {
            //ako je prijavljeni korisnik voditelj:
            if(PrijavljeniKorisnik.Vrste_korisnika.id == 3)
            {
                BtnOtvoriMaterijale.Visible = true;
            }
            //ako je prijavljeni korisnik zaposlenik
            if (PrijavljeniKorisnik.Vrste_korisnika.id == 4)
            {
                BtnOtvoriMaterijale.Visible = false;
            }
        }

        private void RbMaterijali_CheckedChanged(object sender, EventArgs e)
        {
            DgvStavkeSkladista.DataSource = DohvatiNaziveMaterijala();

        }

        private void RbProizvodi_CheckedChanged(object sender, EventArgs e)
        {
            DgvStavkeSkladista.DataSource = DohvatiNaziveProizvoda();
        }

        private void RbSve_CheckedChanged(object sender, EventArgs e)
        {
            OsvjeziFormu();
        }

        private void OsvjeziFormu()
        {
            DohvatiNaziveStavki();
        }

        //Dohvaćanje svih stavki na skladištu
        private void DohvatiNaziveStavki()
        {
            List<SkladisteView> ListaSvihStavaka = DohvatiNaziveProizvoda();

            //zbrajanje listi - svi proizvodi + materijali

            ListaSvihStavaka.AddRange(DohvatiNaziveMaterijala());

            //sortiranje liste po nazivu stvake

            ListaSvihStavaka.Sort((m1, m2) => string.Compare(m1.NazivStavke, m2.NazivStavke));
            DgvStavkeSkladista.DataSource = ListaSvihStavaka;
        }
        private List<SkladisteView> DohvatiNaziveProizvoda()
        {
            using (var context = new EntitiesBaza())
            {
                var queryP = from n in context.Zapisnici_skladista
                             join p in context.Proizvodi
                             on n.proizvod equals p.id
                             join k in context.Korisnici
                             on n.zabiljezio equals k.id
                             where n.materijal == null
                             select new SkladisteView
                             {
                                 Id = n.id,
                                 NazivStavke = p.naziv,
                                 Vrsta = SkladisteView.VrstaStavke.Proizvod,
                                 Kolicina = n.kolicina,
                                 Zabiljezio = k.ime + " " + k.prezime
                             };
                return queryP.ToList();
            }
        }
        private List<SkladisteView> DohvatiNaziveMaterijala()
        {
            using (var context = new EntitiesBaza())
            {
                var queryM = from n in context.Zapisnici_skladista
                             join m in context.Materijali_i_sirovine
                             on n.materijal equals m.id
                             join k in context.Korisnici
                             on n.zabiljezio equals k.id
                             where n.proizvod == null
                             select new SkladisteView
                             {
                                 Id = n.id,
                                 NazivStavke = m.naziv,
                                 Vrsta = SkladisteView.VrstaStavke.Materijal,
                                 Kolicina = n.kolicina,
                                 Zabiljezio = k.ime + " " + k.prezime
                             };
                return queryM.ToList();

            } 
        }
        private void BtnUnosStavke_Click(object sender, EventArgs e)
        {
            UnosStavkeSkladistaForm forma = new UnosStavkeSkladistaForm(PrijavljeniKorisnik);
            forma.ShowDialog();
            OsvjeziFormu();
        }
        private void BtnIzdano_Click(object sender, EventArgs e)
        {
            OtpremaStavkiForm forma = new OtpremaStavkiForm(PrijavljeniKorisnik);
            forma.ShowDialog();
            OsvjeziFormu();
        }

        private void BtnOtvoriMaterijale_Click(object sender, EventArgs e)
        {
            MaterijaliSirovineForm forma = new MaterijaliSirovineForm(PrijavljeniKorisnik);
            forma.ShowDialog();
            OsvjeziFormu();
        }
    }
}
