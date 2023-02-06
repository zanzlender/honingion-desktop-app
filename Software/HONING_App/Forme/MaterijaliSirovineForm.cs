using HONING_App.Database;
using HONING_App.Forme.Skladiste;
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

namespace HONING_App.Forme
{
    public partial class MaterijaliSirovineForm : Form
    {
        Korisnici PrijavljeniKorisnik;
        public MaterijaliSirovineForm(Korisnici prijavljeniKorisnik)
        {
            InitializeComponent();
            PrijavljeniKorisnik = prijavljeniKorisnik;
            OsvjeziFormu();
        }

        private void BtnUnos_Click(object sender, EventArgs e)
        {
            UnosMaterijalaForm forma = new UnosMaterijalaForm(PrijavljeniKorisnik);
            forma.ShowDialog();
            OsvjeziFormu();
        }
        private void OsvjeziFormu()
        {
            DgvMaterijali.DataSource = DohvatiMaterijale();
        }

        private object DohvatiMaterijale()
        {
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Materijali_i_sirovine
                            join p in context.Poslovni_partneri
                            on n.poslovniPartner equals p.id
                            select new MaterijaliSirovineView
                            {
                                Id = n.id,
                                Naziv = n.naziv,
                                Dobavljac = p.imePoduzeca,
                                Specifikacije = n.specifikacija
                            };
                return query.ToList();
            }
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            MaterijaliSirovineView materijaliView = DgvMaterijali.CurrentRow.DataBoundItem as MaterijaliSirovineView;
            Materijali_i_sirovine materijal;
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Materijali_i_sirovine
                            where n.id == materijaliView.Id
                            select n;
                materijal = query.Single();
                context.Materijali_i_sirovine.Attach(materijal);
                context.Materijali_i_sirovine.Remove(materijal);
                context.SaveChanges();
            }
            OsvjeziFormu();
        }

        private void BtnUredi_Click(object sender, EventArgs e)
        {
            MaterijaliSirovineView prikazMaterijala = DgvMaterijali.CurrentRow.DataBoundItem as MaterijaliSirovineView;
            Materijali_i_sirovine materijal;
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Materijali_i_sirovine
                            where n.naziv == prikazMaterijala.Naziv
                            select n;
                materijal = query.Single();
            }
            IzmjenaMaterijalaForm forma = new IzmjenaMaterijalaForm(PrijavljeniKorisnik, materijal);
            forma.ShowDialog();
            OsvjeziFormu();
        }
    }
}
