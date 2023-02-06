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
using HONING_App.Klase;

namespace HONING_App.Forme.Godišnji_odmori
{
    public partial class GodisnjiOdmoriForm : Form
    {
        readonly private Korisnici PrijavljeniKorisnik = new Korisnici();
       
        public GodisnjiOdmoriForm(Korisnici prijavljeniKorisnik)
        {
            PrijavljeniKorisnik = prijavljeniKorisnik;
            InitializeComponent();
            ProvjeraKorisnika();
        }

        private void ProvjeraKorisnika()
        {
            if (PrijavljeniKorisnik.Vrste_korisnika.id == 3)
            {
                dgvGodisnjiOdmori.Visible = true;
                DgvSviZahtjevi.Visible = true;
                BtnPotvrdi.Visible = true;
                BtnOdbij.Visible = true;
                BtnZahtjev.Visible = false;
                LblSviZahtjevi.Visible = true;
                DgvPrivaceniGO.Visible = false;
                GbxKorisnikovOdmor.Visible = false;
                KalendarGodisnjihOdmora.Visible = false;
                LblPopisGodisnjih.Visible = false;
                LblNeobradeniZahtjevi.Visible = true;
                GbxIzmjena.Visible = false;
                BtnUredi.Visible = true;
                panel1.Visible = false;
                DohvatiGodisnjeOdmore();
                DohvatiSveZahtjeve();
            }
            if (PrijavljeniKorisnik.Vrste_korisnika.id == 4)
            {
                dgvGodisnjiOdmori.Visible = true;
                DgvSviZahtjevi.Visible = false;
                BtnPotvrdi.Visible = false;
                BtnOdbij.Visible = false;
                BtnZahtjev.Visible = true;
                BtnUredi.Visible = false;
                LblSviZahtjevi.Visible = false;
                DgvPrivaceniGO.Visible = true;
                GbxKorisnikovOdmor.Visible = true;
                KalendarGodisnjihOdmora.Visible = false;
                LblPopisGodisnjih.Visible = true;
                LblNeobradeniZahtjevi.Visible = false;
                GbxIzmjena.Visible = false;
                panel1.Visible = true;
                DohvatiPrihvaceneGodisnjeOdmore();
                DohvatiKorisnikovOdmor();
            }
        }

        private void DohvatiKorisnikovOdmor()
        {
            Godisnji_odmori KorisnikovOdmor = new Godisnji_odmori();
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Godisnji_odmori
                            where n.korisnik == PrijavljeniKorisnik.id && n.odobreno == true
                            select n;
                KorisnikovOdmor = query.FirstOrDefault();
            }
            if (KorisnikovOdmor != null)
            {
                TxtDatumOd.Text = (KorisnikovOdmor.datumOd.ToString()).Split(' ')[0];
                TxtDatumDo.Text = KorisnikovOdmor.datumDo.ToString();
                KalendarGodisnjihOdmora.MinDate = KorisnikovOdmor.datumOd;
                KalendarGodisnjihOdmora.MaxDate = KorisnikovOdmor.datumDo;

            }
        }

        

        private void DohvatiPrihvaceneGodisnjeOdmore()
        {
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Godisnji_odmori
                            join m in context.Korisnici 
                            on n.korisnik equals m.id
                            where n.odobreno == true
                            select new 
                            {
                                n.id,
                                n.datumOd,
                                n.datumDo,
                                m.ime,
                                m.prezime
                            };
                DgvPrivaceniGO.DataSource = query.ToList();
            }
        }

        private void DohvatiSveZahtjeve()
        {
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Godisnji_odmori
                            join m in context.Korisnici
                            on n.korisnik equals m.id
                            join p in context.Korisnici
                            on n.odobrio equals p.id
                            where n.odobreno == false || n.odobreno == true
                            select new SviGodisnjiOdmoriView
                            {
                                Id = n.id,
                                Ime = m.ime,
                                Prezime = m.prezime,
                                DatumOd = n.datumOd,
                                DatumDo = n.datumDo,
                                ImeVoditelja = p.ime,
                                PrezimeVoditelja = p.prezime,
                                Odobreno = n.odobreno
                            };
                DgvSviZahtjevi.DataSource = query.ToList();
                
            }
        }

        private void DohvatiGodisnjeOdmore()
        {
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Godisnji_odmori
                            join m in context.Korisnici
                            on n.korisnik equals m.id
                            where n.odobreno == null
                            select new GodisnjiOdmoriNeobradeni
                            {
                                Id = n.id,
                                Ime = m.ime,
                                Prezime = m.prezime,
                                DatumOd =n.datumOd,
                                DatumDo = n.datumDo
                            };
                dgvGodisnjiOdmori.DataSource = query.ToList();
            }
            
        }

        private void BtnZahtjev_Click(object sender, EventArgs e)
        {
            Form forma = new ZahtjevGodisnjiOdmorForm(PrijavljeniKorisnik);
            forma.ShowDialog();
            DohvatiGodisnjeOdmore();
            DohvatiSveZahtjeve();
        }

        private void BtnPotvrdi_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite prihvatiti zahtjev?", "Prihvaćanje zahtjeva", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               Godisnji_odmori odabranGodisnjiOdmor = DohvatiGodisnji();
            using (var context = new EntitiesBaza())
            {
                context.Godisnji_odmori.Attach(odabranGodisnjiOdmor);
                odabranGodisnjiOdmor.odobreno = true;
                odabranGodisnjiOdmor.odobrio = PrijavljeniKorisnik.id;
                context.SaveChanges();
            } 
            }
            OsvjeziFormu();
        }

        private Godisnji_odmori DohvatiGodisnji()
        {
            GodisnjiOdmoriNeobradeni odabranGodisnji = dgvGodisnjiOdmori.CurrentRow.DataBoundItem as GodisnjiOdmoriNeobradeni;
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Godisnji_odmori
                            where n.id == odabranGodisnji.Id
                            select n;
                return query.Single();
            }
            
        }

        private void BtnOdbij_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da želite odbiti zahtjev?", "Odbijanje zahtjeva", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Godisnji_odmori odabranGodisnjiOdmor = DohvatiGodisnji();
                using (var context = new EntitiesBaza())
                {
                    context.Godisnji_odmori.Attach(odabranGodisnjiOdmor);
                    odabranGodisnjiOdmor.odobreno = false;
                    odabranGodisnjiOdmor.odobrio = PrijavljeniKorisnik.id;
                    context.SaveChanges();
                }
                OsvjeziFormu();
            }
            
            
            
        }

        private void OsvjeziFormu()
        {
            DohvatiGodisnjeOdmore();
            DohvatiSveZahtjeve();
        }

        private void BtnUredi_Click(object sender, EventArgs e)
        {
            GbxIzmjena.Visible = true;
            BtnUredi.Visible = false; 
            SviGodisnjiOdmoriView odmor = DgvSviZahtjevi.CurrentRow.DataBoundItem as SviGodisnjiOdmoriView;
            bool? odobreno = false;
            if (odmor.Odobreno == true)
            {
                RbPrihvaceno.Checked = true;
                RbOdbijeno.Checked = false;
                odobreno = true;
            }
            if (odmor.Odobreno == false)
            {
                RbPrihvaceno.Checked = false;
                RbOdbijeno.Checked = true;
            }

        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            SviGodisnjiOdmoriView odmor = DgvSviZahtjevi.CurrentRow.DataBoundItem as SviGodisnjiOdmoriView;
            bool? odobreno = RbPrihvaceno.Checked;
            using (var context = new EntitiesBaza())
            {
                var query = from n in context.Godisnji_odmori
                            where n.id == odmor.Id
                            select n;
                Godisnji_odmori OdabranGodisnjiOdmor = query.Single();
                context.Godisnji_odmori.Attach(OdabranGodisnjiOdmor);
                OdabranGodisnjiOdmor.odobreno = odobreno;
                context.SaveChanges();
            }
            GbxIzmjena.Visible = false;
            BtnUredi.Visible = true;
            OsvjeziFormu();
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            GbxIzmjena.Visible = false;
            BtnUredi.Visible = true;
        }

        private void GodisnjiOdmoriForm_Load(object sender, EventArgs e)
        {
            AzurirajPreostaleGodišnje();
        }

        private void AzurirajPreostaleGodišnje()
        {
            Dictionary<string, int> izracunGodisnjeg = KalkulatorGodisnjeg.KalkulatorGodisnjeg.IzracunajGodisnje(PrijavljeniKorisnik.id);

            int ukupno = izracunGodisnjeg.FirstOrDefault(x => x.Key == "ukupno").Value;
            int iskoristeno = izracunGodisnjeg.FirstOrDefault(x => x.Key == "iskoristeno").Value;
            int preostalo = izracunGodisnjeg.FirstOrDefault(x => x.Key == "preostalo").Value;

            LblUkupnoBroj.Text = ukupno.ToString();
            LblIskoristenoBroj.Text = iskoristeno.ToString();
            LblPreostaloBroj.Text = preostalo.ToString();
        }

        private void DgvPrivaceniGO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
