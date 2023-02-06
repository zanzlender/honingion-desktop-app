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

namespace HONING_App.Forme.Dodavanje_poduzeca
{
    public partial class BazaPoduzecaForm : Form
    {
        readonly private Korisnici prijavljeniKorisnik = new Korisnici();
        public BazaPoduzecaForm(Korisnici korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void BazaPoduzecaForm_Load(object sender, EventArgs e)
        {
            LblIspisCekanja.Visible = true;
            PozoviOsvjetiTablicuAsync();
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            int uspjesno = 0;
            DialogResult odgovor = MessageBox.Show("Ova akcija će trajno obrisati poduzeće!\n\n Želite li nastaviti?",
                                   "Brisanje korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (odgovor == DialogResult.Yes)
            {
                Poduzeca odabranoPoduzece = DohvatiOdabranoPoduzece();
                using (var db = new EntitiesBaza())
                {
                    var poduzece = (from p in db.Poduzeca
                                    where p.id == odabranoPoduzece.id
                                    select p).FirstOrDefault();
                    odabranoPoduzece = poduzece;
                    db.Poduzeca.Attach(odabranoPoduzece);
                    db.Poduzeca.Remove(odabranoPoduzece);
                    uspjesno = db.SaveChanges();
                }
                if (uspjesno != 0)
                {
                    MessageBox.Show("Poduzeće je obrisano", "Brisanje poduzeća", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PozoviOsvjetiTablicuAsync();
                }
            }
        }

        private Poduzeca DohvatiOdabranoPoduzece()
        {
            return DgvPoduzeca.CurrentRow.DataBoundItem as Poduzeca;
        }

        private List<Poduzeca> DohvatiPoduzeca()
        {
            List<Poduzeca> dohvacenaPoduzeca = new List<Poduzeca>();
            using (var db = new EntitiesBaza())
            {
                var poduzeca = from p in db.Poduzeca
                               select p;

                dohvacenaPoduzeca = poduzeca.ToList();
            }

            return dohvacenaPoduzeca;
        }

        private Task<List<Poduzeca>> OsvjeziTablicuAsync()
        {
            return Task.Factory.StartNew(() => DohvatiPoduzeca());
        }

        private async void PozoviOsvjetiTablicuAsync()
        {
            //System.Threading.Thread.Sleep(2000);
            DgvPoduzeca.DataSource = await OsvjeziTablicuAsync();
            DgvPoduzeca.Columns["Korisnici"].Visible = false;
            DgvPoduzeca.Columns["Odjeli"].Visible = false;
            LblIspisCekanja.Visible = false;
        }

        private void DgvPoduzeca_SelectionChanged(object sender, EventArgs e)
        {
            BtnIzmijeni.Enabled = true;
            BtnObrisi.Enabled = true;
        }

        private void BtnIzmijeni_Click(object sender, EventArgs e)
        {
            if (DohvatiOdabranoPoduzece() != null)
            {
                Form forma = new IzmijeniPoduzeceForm(DohvatiOdabranoPoduzece());
                forma.ShowDialog();
                PozoviOsvjetiTablicuAsync();
            }
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            Form forma = new DodajPoduzeceForm(prijavljeniKorisnik);
            forma.ShowDialog();
            PozoviOsvjetiTablicuAsync();
        }
    }
}
