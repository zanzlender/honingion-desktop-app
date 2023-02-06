
namespace HONING_App.Forme.Baza_zaposlenika
{
    partial class DodajNovogZaposlenikaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajNovogZaposlenikaForm));
            this.BtnGenerirajLozinku = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CboxPoduzeca = new System.Windows.Forms.ComboBox();
            this.CboxGradovi = new System.Windows.Forms.ComboBox();
            this.CboxOdjeli = new System.Windows.Forms.ComboBox();
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.PanelLozinka = new System.Windows.Forms.Panel();
            this.TxtLozinka = new System.Windows.Forms.TextBox();
            this.CboxUloge = new System.Windows.Forms.ComboBox();
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.LblLozinka = new System.Windows.Forms.Label();
            this.LblPoduzece = new System.Windows.Forms.Label();
            this.PanelOdjel = new System.Windows.Forms.Panel();
            this.LblOdjel = new System.Windows.Forms.Label();
            this.LblUloga = new System.Windows.Forms.Label();
            this.PanelUloga = new System.Windows.Forms.Panel();
            this.PanelMjesto = new System.Windows.Forms.Panel();
            this.PanelPoduzece = new System.Windows.Forms.Panel();
            this.LblMjesto = new System.Windows.Forms.Label();
            this.PanelBroj = new System.Windows.Forms.Panel();
            this.TxtBroj = new System.Windows.Forms.TextBox();
            this.LblBroj = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblOib = new System.Windows.Forms.Label();
            this.PanelIme = new System.Windows.Forms.Panel();
            this.TxtIme = new System.Windows.Forms.TextBox();
            this.LblAdresa = new System.Windows.Forms.Label();
            this.LblPrezime = new System.Windows.Forms.Label();
            this.TxtPrezime = new System.Windows.Forms.TextBox();
            this.PanelAdresa = new System.Windows.Forms.Panel();
            this.TxtAdresa = new System.Windows.Forms.TextBox();
            this.PanelEmail = new System.Windows.Forms.Panel();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.PanelOib = new System.Windows.Forms.Panel();
            this.TxtOib = new System.Windows.Forms.TextBox();
            this.PanelPrezime = new System.Windows.Forms.Panel();
            this.LblIme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.PanelLozinka.SuspendLayout();
            this.PanelOdjel.SuspendLayout();
            this.PanelUloga.SuspendLayout();
            this.PanelMjesto.SuspendLayout();
            this.PanelPoduzece.SuspendLayout();
            this.PanelBroj.SuspendLayout();
            this.PanelIme.SuspendLayout();
            this.PanelAdresa.SuspendLayout();
            this.PanelEmail.SuspendLayout();
            this.PanelOib.SuspendLayout();
            this.PanelPrezime.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGenerirajLozinku
            // 
            this.BtnGenerirajLozinku.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnGenerirajLozinku.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnGenerirajLozinku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerirajLozinku.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerirajLozinku.Location = new System.Drawing.Point(333, 308);
            this.BtnGenerirajLozinku.Name = "BtnGenerirajLozinku";
            this.BtnGenerirajLozinku.Size = new System.Drawing.Size(285, 33);
            this.BtnGenerirajLozinku.TabIndex = 60;
            this.BtnGenerirajLozinku.Text = "GENERIRAJ LOZINKU";
            this.BtnGenerirajLozinku.UseVisualStyleBackColor = false;
            this.BtnGenerirajLozinku.Click += new System.EventHandler(this.BtnGenerirajLozinku_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // CboxPoduzeca
            // 
            this.CboxPoduzeca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboxPoduzeca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboxPoduzeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxPoduzeca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CboxPoduzeca.FormattingEnabled = true;
            this.CboxPoduzeca.ItemHeight = 15;
            this.CboxPoduzeca.Location = new System.Drawing.Point(8, 6);
            this.CboxPoduzeca.Name = "CboxPoduzeca";
            this.CboxPoduzeca.Size = new System.Drawing.Size(277, 23);
            this.CboxPoduzeca.TabIndex = 18;
            // 
            // CboxGradovi
            // 
            this.CboxGradovi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboxGradovi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboxGradovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxGradovi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CboxGradovi.FormattingEnabled = true;
            this.CboxGradovi.ItemHeight = 15;
            this.CboxGradovi.Location = new System.Drawing.Point(8, 7);
            this.CboxGradovi.Name = "CboxGradovi";
            this.CboxGradovi.Size = new System.Drawing.Size(277, 23);
            this.CboxGradovi.TabIndex = 17;
            // 
            // CboxOdjeli
            // 
            this.CboxOdjeli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboxOdjeli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboxOdjeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxOdjeli.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CboxOdjeli.FormattingEnabled = true;
            this.CboxOdjeli.ItemHeight = 15;
            this.CboxOdjeli.Location = new System.Drawing.Point(8, 6);
            this.CboxOdjeli.Name = "CboxOdjeli";
            this.CboxOdjeli.Size = new System.Drawing.Size(277, 23);
            this.CboxOdjeli.TabIndex = 20;
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOdustani.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOdustani.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnOdustani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOdustani.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOdustani.Location = new System.Drawing.Point(338, 434);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(122, 33);
            this.BtnOdustani.TabIndex = 61;
            this.BtnOdustani.Text = "ODUSTANI";
            this.BtnOdustani.UseVisualStyleBackColor = false;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // PanelLozinka
            // 
            this.PanelLozinka.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelLozinka.Controls.Add(this.TxtLozinka);
            this.PanelLozinka.Enabled = false;
            this.PanelLozinka.Location = new System.Drawing.Point(333, 244);
            this.PanelLozinka.Name = "PanelLozinka";
            this.PanelLozinka.Size = new System.Drawing.Size(285, 35);
            this.PanelLozinka.TabIndex = 63;
            // 
            // TxtLozinka
            // 
            this.TxtLozinka.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLozinka.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtLozinka.Location = new System.Drawing.Point(8, 10);
            this.TxtLozinka.Name = "TxtLozinka";
            this.TxtLozinka.ReadOnly = true;
            this.TxtLozinka.Size = new System.Drawing.Size(275, 16);
            this.TxtLozinka.TabIndex = 0;
            // 
            // CboxUloge
            // 
            this.CboxUloge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboxUloge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboxUloge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxUloge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CboxUloge.FormattingEnabled = true;
            this.CboxUloge.ItemHeight = 15;
            this.CboxUloge.Location = new System.Drawing.Point(8, 6);
            this.CboxUloge.Name = "CboxUloge";
            this.CboxUloge.Size = new System.Drawing.Size(277, 23);
            this.CboxUloge.TabIndex = 0;
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.BtnDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(245)))), ((int)(((byte)(128)))));
            this.BtnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDodaj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDodaj.Location = new System.Drawing.Point(496, 434);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(122, 33);
            this.BtnDodaj.TabIndex = 62;
            this.BtnDodaj.Text = "DODAJ";
            this.BtnDodaj.UseVisualStyleBackColor = false;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // LblLozinka
            // 
            this.LblLozinka.AutoSize = true;
            this.LblLozinka.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblLozinka.ForeColor = System.Drawing.Color.DimGray;
            this.LblLozinka.Location = new System.Drawing.Point(330, 224);
            this.LblLozinka.Name = "LblLozinka";
            this.LblLozinka.Size = new System.Drawing.Size(60, 17);
            this.LblLozinka.TabIndex = 55;
            this.LblLozinka.Text = "LOZINKA";
            // 
            // LblPoduzece
            // 
            this.LblPoduzece.AutoSize = true;
            this.LblPoduzece.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPoduzece.ForeColor = System.Drawing.Color.DimGray;
            this.LblPoduzece.Location = new System.Drawing.Point(330, 30);
            this.LblPoduzece.Name = "LblPoduzece";
            this.LblPoduzece.Size = new System.Drawing.Size(72, 17);
            this.LblPoduzece.TabIndex = 57;
            this.LblPoduzece.Text = "PODUZEĆE";
            // 
            // PanelOdjel
            // 
            this.PanelOdjel.BackColor = System.Drawing.Color.White;
            this.PanelOdjel.Controls.Add(this.CboxOdjeli);
            this.PanelOdjel.Location = new System.Drawing.Point(333, 177);
            this.PanelOdjel.Name = "PanelOdjel";
            this.PanelOdjel.Size = new System.Drawing.Size(285, 35);
            this.PanelOdjel.TabIndex = 59;
            // 
            // LblOdjel
            // 
            this.LblOdjel.AutoSize = true;
            this.LblOdjel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblOdjel.ForeColor = System.Drawing.Color.DimGray;
            this.LblOdjel.Location = new System.Drawing.Point(330, 158);
            this.LblOdjel.Name = "LblOdjel";
            this.LblOdjel.Size = new System.Drawing.Size(45, 17);
            this.LblOdjel.TabIndex = 47;
            this.LblOdjel.Text = "ODJEL";
            // 
            // LblUloga
            // 
            this.LblUloga.AutoSize = true;
            this.LblUloga.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblUloga.ForeColor = System.Drawing.Color.DimGray;
            this.LblUloga.Location = new System.Drawing.Point(330, 93);
            this.LblUloga.Name = "LblUloga";
            this.LblUloga.Size = new System.Drawing.Size(50, 17);
            this.LblUloga.TabIndex = 54;
            this.LblUloga.Text = "ULOGA";
            // 
            // PanelUloga
            // 
            this.PanelUloga.BackColor = System.Drawing.Color.White;
            this.PanelUloga.Controls.Add(this.CboxUloge);
            this.PanelUloga.Location = new System.Drawing.Point(333, 113);
            this.PanelUloga.Name = "PanelUloga";
            this.PanelUloga.Size = new System.Drawing.Size(285, 35);
            this.PanelUloga.TabIndex = 58;
            // 
            // PanelMjesto
            // 
            this.PanelMjesto.BackColor = System.Drawing.Color.White;
            this.PanelMjesto.Controls.Add(this.CboxGradovi);
            this.PanelMjesto.Location = new System.Drawing.Point(24, 434);
            this.PanelMjesto.Name = "PanelMjesto";
            this.PanelMjesto.Size = new System.Drawing.Size(285, 35);
            this.PanelMjesto.TabIndex = 53;
            // 
            // PanelPoduzece
            // 
            this.PanelPoduzece.BackColor = System.Drawing.Color.White;
            this.PanelPoduzece.Controls.Add(this.CboxPoduzeca);
            this.PanelPoduzece.Location = new System.Drawing.Point(333, 50);
            this.PanelPoduzece.Name = "PanelPoduzece";
            this.PanelPoduzece.Size = new System.Drawing.Size(285, 35);
            this.PanelPoduzece.TabIndex = 56;
            // 
            // LblMjesto
            // 
            this.LblMjesto.AutoSize = true;
            this.LblMjesto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblMjesto.ForeColor = System.Drawing.Color.DimGray;
            this.LblMjesto.Location = new System.Drawing.Point(21, 416);
            this.LblMjesto.Name = "LblMjesto";
            this.LblMjesto.Size = new System.Drawing.Size(55, 17);
            this.LblMjesto.TabIndex = 50;
            this.LblMjesto.Text = "MJESTO";
            // 
            // PanelBroj
            // 
            this.PanelBroj.BackColor = System.Drawing.Color.White;
            this.PanelBroj.Controls.Add(this.TxtBroj);
            this.PanelBroj.Location = new System.Drawing.Point(24, 306);
            this.PanelBroj.Name = "PanelBroj";
            this.PanelBroj.Size = new System.Drawing.Size(285, 35);
            this.PanelBroj.TabIndex = 49;
            // 
            // TxtBroj
            // 
            this.TxtBroj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBroj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtBroj.Location = new System.Drawing.Point(8, 10);
            this.TxtBroj.Name = "TxtBroj";
            this.TxtBroj.Size = new System.Drawing.Size(275, 16);
            this.TxtBroj.TabIndex = 0;
            // 
            // LblBroj
            // 
            this.LblBroj.AutoSize = true;
            this.LblBroj.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblBroj.ForeColor = System.Drawing.Color.DimGray;
            this.LblBroj.Location = new System.Drawing.Point(21, 287);
            this.LblBroj.Name = "LblBroj";
            this.LblBroj.Size = new System.Drawing.Size(98, 17);
            this.LblBroj.TabIndex = 48;
            this.LblBroj.Text = "KONTAKT BROJ";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.LblEmail.Location = new System.Drawing.Point(21, 223);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(49, 17);
            this.LblEmail.TabIndex = 46;
            this.LblEmail.Text = "E-MAIL";
            // 
            // LblOib
            // 
            this.LblOib.AutoSize = true;
            this.LblOib.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblOib.ForeColor = System.Drawing.Color.DimGray;
            this.LblOib.Location = new System.Drawing.Point(21, 159);
            this.LblOib.Name = "LblOib";
            this.LblOib.Size = new System.Drawing.Size(28, 17);
            this.LblOib.TabIndex = 51;
            this.LblOib.Text = "OIB";
            // 
            // PanelIme
            // 
            this.PanelIme.BackColor = System.Drawing.Color.White;
            this.PanelIme.Controls.Add(this.TxtIme);
            this.PanelIme.Location = new System.Drawing.Point(24, 50);
            this.PanelIme.Name = "PanelIme";
            this.PanelIme.Size = new System.Drawing.Size(285, 35);
            this.PanelIme.TabIndex = 39;
            // 
            // TxtIme
            // 
            this.TxtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtIme.Location = new System.Drawing.Point(8, 10);
            this.TxtIme.Name = "TxtIme";
            this.TxtIme.Size = new System.Drawing.Size(275, 16);
            this.TxtIme.TabIndex = 0;
            // 
            // LblAdresa
            // 
            this.LblAdresa.AutoSize = true;
            this.LblAdresa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblAdresa.ForeColor = System.Drawing.Color.DimGray;
            this.LblAdresa.Location = new System.Drawing.Point(21, 352);
            this.LblAdresa.Name = "LblAdresa";
            this.LblAdresa.Size = new System.Drawing.Size(55, 17);
            this.LblAdresa.TabIndex = 45;
            this.LblAdresa.Text = "ADRESA";
            // 
            // LblPrezime
            // 
            this.LblPrezime.AutoSize = true;
            this.LblPrezime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPrezime.ForeColor = System.Drawing.Color.DimGray;
            this.LblPrezime.Location = new System.Drawing.Point(21, 94);
            this.LblPrezime.Name = "LblPrezime";
            this.LblPrezime.Size = new System.Drawing.Size(59, 17);
            this.LblPrezime.TabIndex = 44;
            this.LblPrezime.Text = "PREZIME";
            // 
            // TxtPrezime
            // 
            this.TxtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrezime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtPrezime.Location = new System.Drawing.Point(8, 10);
            this.TxtPrezime.Name = "TxtPrezime";
            this.TxtPrezime.Size = new System.Drawing.Size(275, 16);
            this.TxtPrezime.TabIndex = 0;
            // 
            // PanelAdresa
            // 
            this.PanelAdresa.BackColor = System.Drawing.Color.White;
            this.PanelAdresa.Controls.Add(this.TxtAdresa);
            this.PanelAdresa.Location = new System.Drawing.Point(24, 370);
            this.PanelAdresa.Name = "PanelAdresa";
            this.PanelAdresa.Size = new System.Drawing.Size(285, 35);
            this.PanelAdresa.TabIndex = 52;
            // 
            // TxtAdresa
            // 
            this.TxtAdresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAdresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtAdresa.Location = new System.Drawing.Point(8, 10);
            this.TxtAdresa.Name = "TxtAdresa";
            this.TxtAdresa.Size = new System.Drawing.Size(275, 16);
            this.TxtAdresa.TabIndex = 0;
            // 
            // PanelEmail
            // 
            this.PanelEmail.BackColor = System.Drawing.Color.White;
            this.PanelEmail.Controls.Add(this.TxtEmail);
            this.PanelEmail.Location = new System.Drawing.Point(24, 242);
            this.PanelEmail.Name = "PanelEmail";
            this.PanelEmail.Size = new System.Drawing.Size(285, 35);
            this.PanelEmail.TabIndex = 43;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEmail.Location = new System.Drawing.Point(8, 10);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(275, 16);
            this.TxtEmail.TabIndex = 0;
            // 
            // PanelOib
            // 
            this.PanelOib.BackColor = System.Drawing.Color.White;
            this.PanelOib.Controls.Add(this.TxtOib);
            this.PanelOib.Location = new System.Drawing.Point(24, 178);
            this.PanelOib.Name = "PanelOib";
            this.PanelOib.Size = new System.Drawing.Size(285, 35);
            this.PanelOib.TabIndex = 42;
            // 
            // TxtOib
            // 
            this.TxtOib.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOib.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtOib.Location = new System.Drawing.Point(8, 10);
            this.TxtOib.Name = "TxtOib";
            this.TxtOib.Size = new System.Drawing.Size(275, 16);
            this.TxtOib.TabIndex = 0;
            // 
            // PanelPrezime
            // 
            this.PanelPrezime.BackColor = System.Drawing.Color.White;
            this.PanelPrezime.Controls.Add(this.TxtPrezime);
            this.PanelPrezime.Location = new System.Drawing.Point(24, 114);
            this.PanelPrezime.Name = "PanelPrezime";
            this.PanelPrezime.Size = new System.Drawing.Size(285, 35);
            this.PanelPrezime.TabIndex = 41;
            // 
            // LblIme
            // 
            this.LblIme.AutoSize = true;
            this.LblIme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblIme.ForeColor = System.Drawing.Color.DimGray;
            this.LblIme.Location = new System.Drawing.Point(21, 30);
            this.LblIme.Name = "LblIme";
            this.LblIme.Size = new System.Drawing.Size(30, 17);
            this.LblIme.TabIndex = 40;
            this.LblIme.Text = "IME";
            // 
            // DodajNovogZaposlenikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(647, 508);
            this.Controls.Add(this.BtnGenerirajLozinku);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.PanelLozinka);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.LblLozinka);
            this.Controls.Add(this.LblPoduzece);
            this.Controls.Add(this.PanelOdjel);
            this.Controls.Add(this.LblOdjel);
            this.Controls.Add(this.LblUloga);
            this.Controls.Add(this.PanelUloga);
            this.Controls.Add(this.PanelMjesto);
            this.Controls.Add(this.PanelPoduzece);
            this.Controls.Add(this.LblMjesto);
            this.Controls.Add(this.PanelBroj);
            this.Controls.Add(this.LblBroj);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblOib);
            this.Controls.Add(this.PanelIme);
            this.Controls.Add(this.LblAdresa);
            this.Controls.Add(this.LblPrezime);
            this.Controls.Add(this.PanelAdresa);
            this.Controls.Add(this.PanelEmail);
            this.Controls.Add(this.PanelOib);
            this.Controls.Add(this.PanelPrezime);
            this.Controls.Add(this.LblIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajNovogZaposlenikaForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj zaposlenika";
            this.Load += new System.EventHandler(this.DodajNovogZaposlenikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.PanelLozinka.ResumeLayout(false);
            this.PanelLozinka.PerformLayout();
            this.PanelOdjel.ResumeLayout(false);
            this.PanelUloga.ResumeLayout(false);
            this.PanelMjesto.ResumeLayout(false);
            this.PanelPoduzece.ResumeLayout(false);
            this.PanelBroj.ResumeLayout(false);
            this.PanelBroj.PerformLayout();
            this.PanelIme.ResumeLayout(false);
            this.PanelIme.PerformLayout();
            this.PanelAdresa.ResumeLayout(false);
            this.PanelAdresa.PerformLayout();
            this.PanelEmail.ResumeLayout(false);
            this.PanelEmail.PerformLayout();
            this.PanelOib.ResumeLayout(false);
            this.PanelOib.PerformLayout();
            this.PanelPrezime.ResumeLayout(false);
            this.PanelPrezime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerirajLozinku;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Panel PanelLozinka;
        private System.Windows.Forms.TextBox TxtLozinka;
        private System.Windows.Forms.Button BtnDodaj;
        private System.Windows.Forms.Label LblLozinka;
        private System.Windows.Forms.Label LblPoduzece;
        private System.Windows.Forms.Panel PanelOdjel;
        private System.Windows.Forms.ComboBox CboxOdjeli;
        private System.Windows.Forms.Label LblOdjel;
        private System.Windows.Forms.Label LblUloga;
        private System.Windows.Forms.Panel PanelUloga;
        private System.Windows.Forms.ComboBox CboxUloge;
        private System.Windows.Forms.Panel PanelMjesto;
        private System.Windows.Forms.ComboBox CboxGradovi;
        private System.Windows.Forms.Panel PanelPoduzece;
        private System.Windows.Forms.ComboBox CboxPoduzeca;
        private System.Windows.Forms.Label LblMjesto;
        private System.Windows.Forms.Panel PanelBroj;
        private System.Windows.Forms.TextBox TxtBroj;
        private System.Windows.Forms.Label LblBroj;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblOib;
        private System.Windows.Forms.Panel PanelIme;
        private System.Windows.Forms.TextBox TxtIme;
        private System.Windows.Forms.Label LblAdresa;
        private System.Windows.Forms.Label LblPrezime;
        private System.Windows.Forms.Panel PanelAdresa;
        private System.Windows.Forms.TextBox TxtAdresa;
        private System.Windows.Forms.Panel PanelEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Panel PanelOib;
        private System.Windows.Forms.TextBox TxtOib;
        private System.Windows.Forms.Panel PanelPrezime;
        private System.Windows.Forms.TextBox TxtPrezime;
        private System.Windows.Forms.Label LblIme;
    }
}