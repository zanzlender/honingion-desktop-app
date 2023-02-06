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
    public partial class OtpremaStavkiForm : Form
    {
        Korisnici PrijavljeniKorisnik;
        public OtpremaStavkiForm(Korisnici prijavljeniKorisnik)
        {
            InitializeComponent();
            PrijavljeniKorisnik = prijavljeniKorisnik;
        }
        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            if (RbMaterijal.Checked == true)
            {
                OtpremiMaterijal();
            }
            if (RbProizvod.Checked == true)
            {
                OtpremiProizvod();
            }
        }
        private void OtpremiMaterijal()
        {
            string naziv = CmbNaziv.SelectedItem.ToString();
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Zapisnici_skladista
                            join m in context.Materijali_i_sirovine
                            on n.materijal equals m.id
                            where m.naziv == naziv
                            select n;
                Zapisnici_skladista stavka = query.Single();
                int trenutnaKolicina = stavka.kolicina;
                if (int.Parse(TxtKolicina.Text)>stavka.kolicina)
                {
                    MessageBox.Show("Unos nije ispravan. /Kolicina");
                }
                if(int.Parse(TxtKolicina.Text)==stavka.kolicina)
                {
                    context.Zapisnici_skladista.Attach(stavka);
                    context.Zapisnici_skladista.Remove(stavka);
                    context.SaveChanges();
                }
                else
                {
                    context.Zapisnici_skladista.Attach(stavka);
                    stavka.kolicina = trenutnaKolicina - int.Parse(TxtKolicina.Text);
                    context.SaveChanges();
                }
            }
            this.Close();
        }
        private void OtpremiProizvod()
        {
            string naziv = CmbNaziv.SelectedItem.ToString();
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Zapisnici_skladista
                            join p in context.Proizvodi
                            on n.proizvod equals p.id
                            where p.naziv == naziv
                            select n;
                Zapisnici_skladista stavka = query.Single();
                int trenutnaKolicina = stavka.kolicina;
                if (int.Parse(TxtKolicina.Text) > stavka.kolicina)
                {
                    MessageBox.Show("Unos nije ispravan. /Kolicina");
                }
                if (int.Parse(TxtKolicina.Text) == stavka.kolicina)
                {
                    context.Zapisnici_skladista.Attach(stavka);
                    context.Zapisnici_skladista.Remove(stavka);
                    context.SaveChanges();
                }
                else
                {
                    context.Zapisnici_skladista.Attach(stavka);
                    stavka.kolicina = trenutnaKolicina - int.Parse(TxtKolicina.Text);
                    context.SaveChanges();
                }
            }
            this.Close();
        }

        private void RbProizvod_CheckedChanged(object sender, EventArgs e)
        {
            PopuniCombo();
        }

        private void RbMaterijal_CheckedChanged(object sender, EventArgs e)
        {
            PopuniCombo();
        }

        private void PopuniCombo()
        {
            if (RbMaterijal.Checked == true)
            {
                using (var context = new EntitiesBaza())
                {
                    var query = from n in context.Zapisnici_skladista
                                join m in context.Materijali_i_sirovine
                                on n.materijal equals m.id
                                select m.naziv;
                    CmbNaziv.DataSource = query.ToList();
                }
            }
            if (RbProizvod.Checked == true)
            {
                using (var context = new EntitiesBaza())
                {
                    var query = from n in context.Zapisnici_skladista
                                join p in context.Proizvodi
                                on n.proizvod equals p.id
                                select p.naziv;
                    CmbNaziv.DataSource = query.ToList();
                }
            }
        }
    }
}
