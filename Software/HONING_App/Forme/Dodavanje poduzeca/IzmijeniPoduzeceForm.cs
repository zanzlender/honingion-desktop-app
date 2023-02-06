using HONING_App.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HONING_App.Forme.Dodavanje_poduzeca
{
    public partial class IzmijeniPoduzeceForm : Form
    {
        readonly Poduzeca odabranoPoduzece = new Poduzeca();
        public IzmijeniPoduzeceForm(Poduzeca poduzece)
        {
            InitializeComponent();
            odabranoPoduzece = poduzece;
        }

        private void IzmijeniPoduzeceForm_Load(object sender, EventArgs e)
        {
            TxtNaziv.Text = odabranoPoduzece.naziv;
            TxtOib.Text = odabranoPoduzece.oib;
            TxtVoditelj.Text = odabranoPoduzece.voditelj;
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new EntitiesBaza())
            {
                db.Poduzeca.Attach(odabranoPoduzece);
                odabranoPoduzece.naziv = TxtNaziv.Text;
                odabranoPoduzece.voditelj = TxtVoditelj.Text;
                odabranoPoduzece.oib = TxtOib.Text;

                db.SaveChanges();

                MessageBox.Show("Poduzeće uspješno izmijenjeno!", "Izmjena poduzeća", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Close();
        }
    }
}
