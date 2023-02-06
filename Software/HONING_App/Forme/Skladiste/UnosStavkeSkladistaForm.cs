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
    public partial class UnosStavkeSkladistaForm : Form
    {
        Korisnici PrijavljeniKorisnik;
        public UnosStavkeSkladistaForm(Korisnici prijavljeniKorisnik)
        {
            InitializeComponent();
            PrijavljeniKorisnik = prijavljeniKorisnik;
        }

        private void RbProizvod_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Proizvodi
                            select n.naziv;
                CmbNaziv.DataSource = query.ToList();
            }
        }

        private void RbMaterijal_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Materijali_i_sirovine
                            select n.naziv;
                CmbNaziv.DataSource = query.ToList();
            }
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            Zapisnici_skladista zapisnik;
            if (RbMaterijal.Checked == true)
            {
                if (DohvatiZapisMaterijala() == null)
                {
                    //dodavanje novog zapisa skladista za materijal
                    Materijali_i_sirovine materijal = DohvatiMaterijal();
                    zapisnik = new Zapisnici_skladista()
                    {
                        materijal = materijal.id,
                        kolicina = int.Parse(TxtKolicina.Text),
                        zabiljezio = PrijavljeniKorisnik.id,
                        datumVrijeme = System.DateTime.Now
                    };
                    using (var context = new EntitiesBaza())
                    {
                        context.Zapisnici_skladista.Add(zapisnik);
                        context.SaveChanges();
                    }
                }
                else
                {
                    zapisnik = DohvatiZapisMaterijala();
                    using (var context = new EntitiesBaza())
                    {
                        var query = from n in context.Zapisnici_skladista
                                    where n.id == zapisnik.id
                                    select n.kolicina;
                        context.Zapisnici_skladista.Attach(zapisnik);
                        zapisnik.kolicina = query.Single() + int.Parse(TxtKolicina.Text);
                        context.SaveChanges();
                    }

                }
                
            }
            if (RbProizvod.Checked == true)
            {
                if (DohvatiZapisProizvoda() == null)
                {
                    //dodavanje novog zapisa skladista za proizvod
                    Proizvodi proizvod = DohvatiProizvod();
                    zapisnik = new Zapisnici_skladista()
                    {
                        proizvod = proizvod.id,
                        kolicina = int.Parse(TxtKolicina.Text),
                        zabiljezio = PrijavljeniKorisnik.id,
                        datumVrijeme = System.DateTime.Now
                    };
                    using (var context = new EntitiesBaza())
                    {
                        context.Zapisnici_skladista.Add(zapisnik);
                        context.SaveChanges();
                    }
                }
                else
                {
                    zapisnik = DohvatiZapisProizvoda();
                    using (var context = new EntitiesBaza())
                    {
                        var query = from n in context.Zapisnici_skladista
                                    where n.id == zapisnik.id
                                    select n.kolicina;
                        context.Zapisnici_skladista.Attach(zapisnik);
                        zapisnik.kolicina = query.Single() + int.Parse(TxtKolicina.Text);
                        context.SaveChanges();
                    }
                }
            }
            this.Close();
        }
        private Zapisnici_skladista DohvatiZapisMaterijala()
        {
            string naziv = CmbNaziv.SelectedItem.ToString();
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Zapisnici_skladista
                            join m in context.Materijali_i_sirovine
                            on n.materijal equals m.id
                            where n.proizvod == null && m.naziv == naziv
                            select n;
                return query.FirstOrDefault();
            }
        }

        private Zapisnici_skladista DohvatiZapisProizvoda()
        {
            string naziv = CmbNaziv.SelectedItem.ToString();
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Zapisnici_skladista
                            join m in context.Proizvodi
                            on n.proizvod equals m.id
                            where n.materijal == null && m.naziv == naziv
                            select n;
                return query.FirstOrDefault();
            }
        }

        private Materijali_i_sirovine DohvatiMaterijal()
        {
            string materijal = CmbNaziv.SelectedItem.ToString();
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Materijali_i_sirovine
                            where n.naziv == materijal
                            select n;
                return query.Single();
                
            }
        }

        private Proizvodi DohvatiProizvod()
        {
            string proizvod = CmbNaziv.SelectedItem.ToString();
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Proizvodi
                            where n.naziv == proizvod
                            select n;
                return query.Single();
            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
