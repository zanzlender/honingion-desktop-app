
namespace HONING_App.Forme.Baza_zaposlenika
{
    partial class IzmijeniZaposlenikaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmijeniZaposlenikaForm));
            this.PanelMjesto = new System.Windows.Forms.Panel();
            this.CboxGradovi = new System.Windows.Forms.ComboBox();
            this.PanelUloga = new System.Windows.Forms.Panel();
            this.CboxUloge = new System.Windows.Forms.ComboBox();
            this.LblMjesto = new System.Windows.Forms.Label();
            this.PanelAdresa = new System.Windows.Forms.Panel();
            this.TxtAdresa = new System.Windows.Forms.TextBox();
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.PanelOdjel = new System.Windows.Forms.Panel();
            this.CboxOdjeli = new System.Windows.Forms.ComboBox();
            this.LblUloga = new System.Windows.Forms.Label();
            this.PanelPoduzece = new System.Windows.Forms.Panel();
            this.CboxPoduzeca = new System.Windows.Forms.ComboBox();
            this.PanelLozinka = new System.Windows.Forms.Panel();
            this.TxtLozinka = new System.Windows.Forms.TextBox();
            this.LblPoduzece = new System.Windows.Forms.Label();
            this.BtnIzmijeni = new System.Windows.Forms.Button();
            this.LblLozinka = new System.Windows.Forms.Label();
            this.LblOdjel = new System.Windows.Forms.Label();
            this.LblAdresa = new System.Windows.Forms.Label();
            this.LblBroj = new System.Windows.Forms.Label();
            this.TxtBroj = new System.Windows.Forms.TextBox();
            this.PanelBroj = new System.Windows.Forms.Panel();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.PanelEmail = new System.Windows.Forms.Panel();
            this.LblOib = new System.Windows.Forms.Label();
            this.TxtOib = new System.Windows.Forms.TextBox();
            this.PanelOib = new System.Windows.Forms.Panel();
            this.LblPrezime = new System.Windows.Forms.Label();
            this.TxtPrezime = new System.Windows.Forms.TextBox();
            this.PanelPrezime = new System.Windows.Forms.Panel();
            this.TxtIme = new System.Windows.Forms.TextBox();
            this.PanelIme = new System.Windows.Forms.Panel();
            this.LblIme = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelMjesto.SuspendLayout();
            this.PanelUloga.SuspendLayout();
            this.PanelAdresa.SuspendLayout();
            this.PanelOdjel.SuspendLayout();
            this.PanelPoduzece.SuspendLayout();
            this.PanelLozinka.SuspendLayout();
            this.PanelBroj.SuspendLayout();
            this.PanelEmail.SuspendLayout();
            this.PanelOib.SuspendLayout();
            this.PanelPrezime.SuspendLayout();
            this.PanelIme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMjesto
            // 
            this.PanelMjesto.BackColor = System.Drawing.Color.White;
            this.PanelMjesto.Controls.Add(this.CboxGradovi);
            this.PanelMjesto.Location = new System.Drawing.Point(22, 427);
            this.PanelMjesto.Name = "PanelMjesto";
            this.PanelMjesto.Size = new System.Drawing.Size(285, 35);
            this.PanelMjesto.TabIndex = 33;
            // 
            // CboxGradovi
            // 
            this.CboxGradovi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboxGradovi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboxGradovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboxGradovi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CboxGradovi.FormattingEnabled = true;
            this.CboxGradovi.ItemHeight = 15;
            this.CboxGradovi.Location = new System.Drawing.Point(8, 6);
            this.CboxGradovi.Name = "CboxGradovi";
            this.CboxGradovi.Size = new System.Drawing.Size(277, 23);
            this.CboxGradovi.TabIndex = 41;
            this.CboxGradovi.Validating += new System.ComponentModel.CancelEventHandler(this.CboxGradovi_Validating);
            this.CboxGradovi.Validated += new System.EventHandler(this.CboxGradovi_Validated);
            // 
            // PanelUloga
            // 
            this.PanelUloga.BackColor = System.Drawing.Color.White;
            this.PanelUloga.Controls.Add(this.CboxUloge);
            this.PanelUloga.Location = new System.Drawing.Point(331, 106);
            this.PanelUloga.Name = "PanelUloga";
            this.PanelUloga.Size = new System.Drawing.Size(285, 35);
            this.PanelUloga.TabIndex = 35;
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
            this.CboxUloge.TabIndex = 43;
            this.CboxUloge.Validating += new System.ComponentModel.CancelEventHandler(this.CboxUloge_Validating);
            this.CboxUloge.Validated += new System.EventHandler(this.CboxUloge_Validated);
            // 
            // LblMjesto
            // 
            this.LblMjesto.AutoSize = true;
            this.LblMjesto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblMjesto.ForeColor = System.Drawing.Color.DimGray;
            this.LblMjesto.Location = new System.Drawing.Point(19, 409);
            this.LblMjesto.Name = "LblMjesto";
            this.LblMjesto.Size = new System.Drawing.Size(55, 17);
            this.LblMjesto.TabIndex = 20;
            this.LblMjesto.Text = "MJESTO";
            // 
            // PanelAdresa
            // 
            this.PanelAdresa.BackColor = System.Drawing.Color.White;
            this.PanelAdresa.Controls.Add(this.TxtAdresa);
            this.PanelAdresa.Location = new System.Drawing.Point(22, 363);
            this.PanelAdresa.Name = "PanelAdresa";
            this.PanelAdresa.Size = new System.Drawing.Size(285, 35);
            this.PanelAdresa.TabIndex = 31;
            // 
            // TxtAdresa
            // 
            this.TxtAdresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAdresa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtAdresa.Location = new System.Drawing.Point(8, 10);
            this.TxtAdresa.Name = "TxtAdresa";
            this.TxtAdresa.Size = new System.Drawing.Size(275, 16);
            this.TxtAdresa.TabIndex = 0;
            this.TxtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAdresa_Validating);
            this.TxtAdresa.Validated += new System.EventHandler(this.TxtAdresa_Validated);
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
            this.BtnOdustani.Location = new System.Drawing.Point(336, 427);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(122, 33);
            this.BtnOdustani.TabIndex = 40;
            this.BtnOdustani.Text = "ODUSTANI";
            this.BtnOdustani.UseVisualStyleBackColor = false;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // PanelOdjel
            // 
            this.PanelOdjel.BackColor = System.Drawing.Color.White;
            this.PanelOdjel.Controls.Add(this.CboxOdjeli);
            this.PanelOdjel.Location = new System.Drawing.Point(331, 170);
            this.PanelOdjel.Name = "PanelOdjel";
            this.PanelOdjel.Size = new System.Drawing.Size(285, 35);
            this.PanelOdjel.TabIndex = 36;
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
            this.CboxOdjeli.TabIndex = 44;
            this.CboxOdjeli.Validating += new System.ComponentModel.CancelEventHandler(this.CboxOdjeli_Validating);
            this.CboxOdjeli.Validated += new System.EventHandler(this.CboxOdjeli_Validated);
            // 
            // LblUloga
            // 
            this.LblUloga.AutoSize = true;
            this.LblUloga.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblUloga.ForeColor = System.Drawing.Color.DimGray;
            this.LblUloga.Location = new System.Drawing.Point(328, 86);
            this.LblUloga.Name = "LblUloga";
            this.LblUloga.Size = new System.Drawing.Size(50, 17);
            this.LblUloga.TabIndex = 30;
            this.LblUloga.Text = "ULOGA";
            // 
            // PanelPoduzece
            // 
            this.PanelPoduzece.BackColor = System.Drawing.Color.White;
            this.PanelPoduzece.Controls.Add(this.CboxPoduzeca);
            this.PanelPoduzece.Location = new System.Drawing.Point(331, 43);
            this.PanelPoduzece.Name = "PanelPoduzece";
            this.PanelPoduzece.Size = new System.Drawing.Size(285, 35);
            this.PanelPoduzece.TabIndex = 34;
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
            this.CboxPoduzeca.TabIndex = 42;
            this.CboxPoduzeca.SelectedValueChanged += new System.EventHandler(this.CboxPoduzeca_SelectedValueChanged);
            this.CboxPoduzeca.Validating += new System.ComponentModel.CancelEventHandler(this.CboxPoduzeca_Validating);
            this.CboxPoduzeca.Validated += new System.EventHandler(this.CboxPoduzeca_Validated);
            // 
            // PanelLozinka
            // 
            this.PanelLozinka.BackColor = System.Drawing.Color.White;
            this.PanelLozinka.Controls.Add(this.TxtLozinka);
            this.PanelLozinka.Location = new System.Drawing.Point(331, 237);
            this.PanelLozinka.Name = "PanelLozinka";
            this.PanelLozinka.Size = new System.Drawing.Size(285, 35);
            this.PanelLozinka.TabIndex = 37;
            // 
            // TxtLozinka
            // 
            this.TxtLozinka.BackColor = System.Drawing.Color.White;
            this.TxtLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLozinka.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtLozinka.Location = new System.Drawing.Point(8, 10);
            this.TxtLozinka.Name = "TxtLozinka";
            this.TxtLozinka.Size = new System.Drawing.Size(275, 16);
            this.TxtLozinka.TabIndex = 1;
            this.TxtLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLozinka_Validating);
            this.TxtLozinka.Validated += new System.EventHandler(this.TxtLozinka_Validated);
            // 
            // LblPoduzece
            // 
            this.LblPoduzece.AutoSize = true;
            this.LblPoduzece.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPoduzece.ForeColor = System.Drawing.Color.DimGray;
            this.LblPoduzece.Location = new System.Drawing.Point(328, 23);
            this.LblPoduzece.Name = "LblPoduzece";
            this.LblPoduzece.Size = new System.Drawing.Size(72, 17);
            this.LblPoduzece.TabIndex = 32;
            this.LblPoduzece.Text = "PODUZEĆE";
            // 
            // BtnIzmijeni
            // 
            this.BtnIzmijeni.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnIzmijeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIzmijeni.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnIzmijeni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(199)))), ((int)(((byte)(63)))));
            this.BtnIzmijeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(245)))), ((int)(((byte)(128)))));
            this.BtnIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzmijeni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzmijeni.Location = new System.Drawing.Point(494, 427);
            this.BtnIzmijeni.Name = "BtnIzmijeni";
            this.BtnIzmijeni.Size = new System.Drawing.Size(122, 33);
            this.BtnIzmijeni.TabIndex = 39;
            this.BtnIzmijeni.Text = "SPREMI";
            this.BtnIzmijeni.UseVisualStyleBackColor = false;
            this.BtnIzmijeni.Click += new System.EventHandler(this.BtnIzmijeni_Click);
            // 
            // LblLozinka
            // 
            this.LblLozinka.AutoSize = true;
            this.LblLozinka.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblLozinka.ForeColor = System.Drawing.Color.DimGray;
            this.LblLozinka.Location = new System.Drawing.Point(328, 217);
            this.LblLozinka.Name = "LblLozinka";
            this.LblLozinka.Size = new System.Drawing.Size(60, 17);
            this.LblLozinka.TabIndex = 29;
            this.LblLozinka.Text = "LOZINKA";
            // 
            // LblOdjel
            // 
            this.LblOdjel.AutoSize = true;
            this.LblOdjel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblOdjel.ForeColor = System.Drawing.Color.DimGray;
            this.LblOdjel.Location = new System.Drawing.Point(328, 150);
            this.LblOdjel.Name = "LblOdjel";
            this.LblOdjel.Size = new System.Drawing.Size(45, 17);
            this.LblOdjel.TabIndex = 25;
            this.LblOdjel.Text = "ODJEL";
            // 
            // LblAdresa
            // 
            this.LblAdresa.AutoSize = true;
            this.LblAdresa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblAdresa.ForeColor = System.Drawing.Color.DimGray;
            this.LblAdresa.Location = new System.Drawing.Point(19, 345);
            this.LblAdresa.Name = "LblAdresa";
            this.LblAdresa.Size = new System.Drawing.Size(55, 17);
            this.LblAdresa.TabIndex = 24;
            this.LblAdresa.Text = "ADRESA";
            // 
            // LblBroj
            // 
            this.LblBroj.AutoSize = true;
            this.LblBroj.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblBroj.ForeColor = System.Drawing.Color.DimGray;
            this.LblBroj.Location = new System.Drawing.Point(19, 281);
            this.LblBroj.Name = "LblBroj";
            this.LblBroj.Size = new System.Drawing.Size(98, 17);
            this.LblBroj.TabIndex = 23;
            this.LblBroj.Text = "KONTAKT BROJ";
            // 
            // TxtBroj
            // 
            this.TxtBroj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBroj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtBroj.Location = new System.Drawing.Point(8, 10);
            this.TxtBroj.Name = "TxtBroj";
            this.TxtBroj.Size = new System.Drawing.Size(275, 16);
            this.TxtBroj.TabIndex = 0;
            this.TxtBroj.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBroj_Validating);
            this.TxtBroj.Validated += new System.EventHandler(this.TxtBroj_Validated);
            // 
            // PanelBroj
            // 
            this.PanelBroj.BackColor = System.Drawing.Color.White;
            this.PanelBroj.Controls.Add(this.TxtBroj);
            this.PanelBroj.Location = new System.Drawing.Point(22, 299);
            this.PanelBroj.Name = "PanelBroj";
            this.PanelBroj.Size = new System.Drawing.Size(285, 35);
            this.PanelBroj.TabIndex = 28;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.LblEmail.Location = new System.Drawing.Point(19, 217);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(49, 17);
            this.LblEmail.TabIndex = 22;
            this.LblEmail.Text = "E-MAIL";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEmail.Location = new System.Drawing.Point(8, 10);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(275, 16);
            this.TxtEmail.TabIndex = 0;
            this.TxtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            this.TxtEmail.Validated += new System.EventHandler(this.TxtEmail_Validated);
            // 
            // PanelEmail
            // 
            this.PanelEmail.BackColor = System.Drawing.Color.White;
            this.PanelEmail.Controls.Add(this.TxtEmail);
            this.PanelEmail.Location = new System.Drawing.Point(22, 235);
            this.PanelEmail.Name = "PanelEmail";
            this.PanelEmail.Size = new System.Drawing.Size(285, 35);
            this.PanelEmail.TabIndex = 27;
            // 
            // LblOib
            // 
            this.LblOib.AutoSize = true;
            this.LblOib.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblOib.ForeColor = System.Drawing.Color.DimGray;
            this.LblOib.Location = new System.Drawing.Point(19, 153);
            this.LblOib.Name = "LblOib";
            this.LblOib.Size = new System.Drawing.Size(28, 17);
            this.LblOib.TabIndex = 26;
            this.LblOib.Text = "OIB";
            // 
            // TxtOib
            // 
            this.TxtOib.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOib.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtOib.Location = new System.Drawing.Point(8, 10);
            this.TxtOib.Name = "TxtOib";
            this.TxtOib.Size = new System.Drawing.Size(275, 16);
            this.TxtOib.TabIndex = 0;
            this.TxtOib.Validating += new System.ComponentModel.CancelEventHandler(this.TxtOib_Validating);
            this.TxtOib.Validated += new System.EventHandler(this.TxtOib_Validated);
            // 
            // PanelOib
            // 
            this.PanelOib.BackColor = System.Drawing.Color.White;
            this.PanelOib.Controls.Add(this.TxtOib);
            this.PanelOib.Location = new System.Drawing.Point(22, 171);
            this.PanelOib.Name = "PanelOib";
            this.PanelOib.Size = new System.Drawing.Size(285, 35);
            this.PanelOib.TabIndex = 21;
            // 
            // LblPrezime
            // 
            this.LblPrezime.AutoSize = true;
            this.LblPrezime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPrezime.ForeColor = System.Drawing.Color.DimGray;
            this.LblPrezime.Location = new System.Drawing.Point(19, 88);
            this.LblPrezime.Name = "LblPrezime";
            this.LblPrezime.Size = new System.Drawing.Size(59, 17);
            this.LblPrezime.TabIndex = 19;
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
            this.TxtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrezime_Validating);
            this.TxtPrezime.Validated += new System.EventHandler(this.TxtPrezime_Validated);
            // 
            // PanelPrezime
            // 
            this.PanelPrezime.BackColor = System.Drawing.Color.White;
            this.PanelPrezime.Controls.Add(this.TxtPrezime);
            this.PanelPrezime.Location = new System.Drawing.Point(22, 107);
            this.PanelPrezime.Name = "PanelPrezime";
            this.PanelPrezime.Size = new System.Drawing.Size(285, 35);
            this.PanelPrezime.TabIndex = 18;
            // 
            // TxtIme
            // 
            this.TxtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtIme.Location = new System.Drawing.Point(8, 10);
            this.TxtIme.Name = "TxtIme";
            this.TxtIme.Size = new System.Drawing.Size(275, 16);
            this.TxtIme.TabIndex = 0;
            this.TxtIme.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIme_Validating);
            this.TxtIme.Validated += new System.EventHandler(this.TxtIme_Validated);
            // 
            // PanelIme
            // 
            this.PanelIme.BackColor = System.Drawing.Color.White;
            this.PanelIme.Controls.Add(this.TxtIme);
            this.PanelIme.Location = new System.Drawing.Point(22, 43);
            this.PanelIme.Name = "PanelIme";
            this.PanelIme.Size = new System.Drawing.Size(285, 35);
            this.PanelIme.TabIndex = 17;
            // 
            // LblIme
            // 
            this.LblIme.AutoSize = true;
            this.LblIme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblIme.ForeColor = System.Drawing.Color.DimGray;
            this.LblIme.Location = new System.Drawing.Point(19, 23);
            this.LblIme.Name = "LblIme";
            this.LblIme.Size = new System.Drawing.Size(30, 17);
            this.LblIme.TabIndex = 16;
            this.LblIme.Text = "IME";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // IzmijeniZaposlenikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 495);
            this.Controls.Add(this.PanelMjesto);
            this.Controls.Add(this.PanelUloga);
            this.Controls.Add(this.LblMjesto);
            this.Controls.Add(this.PanelAdresa);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.PanelOdjel);
            this.Controls.Add(this.LblUloga);
            this.Controls.Add(this.PanelPoduzece);
            this.Controls.Add(this.PanelLozinka);
            this.Controls.Add(this.LblPoduzece);
            this.Controls.Add(this.BtnIzmijeni);
            this.Controls.Add(this.LblLozinka);
            this.Controls.Add(this.LblOdjel);
            this.Controls.Add(this.LblAdresa);
            this.Controls.Add(this.LblBroj);
            this.Controls.Add(this.PanelBroj);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.PanelEmail);
            this.Controls.Add(this.LblOib);
            this.Controls.Add(this.PanelOib);
            this.Controls.Add(this.LblPrezime);
            this.Controls.Add(this.PanelPrezime);
            this.Controls.Add(this.PanelIme);
            this.Controls.Add(this.LblIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzmijeniZaposlenikaForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmijeni zaposlenika";
            this.Load += new System.EventHandler(this.IzmijeniZaposlenikaForm_Load);
            this.PanelMjesto.ResumeLayout(false);
            this.PanelUloga.ResumeLayout(false);
            this.PanelAdresa.ResumeLayout(false);
            this.PanelAdresa.PerformLayout();
            this.PanelOdjel.ResumeLayout(false);
            this.PanelPoduzece.ResumeLayout(false);
            this.PanelLozinka.ResumeLayout(false);
            this.PanelLozinka.PerformLayout();
            this.PanelBroj.ResumeLayout(false);
            this.PanelBroj.PerformLayout();
            this.PanelEmail.ResumeLayout(false);
            this.PanelEmail.PerformLayout();
            this.PanelOib.ResumeLayout(false);
            this.PanelOib.PerformLayout();
            this.PanelPrezime.ResumeLayout(false);
            this.PanelPrezime.PerformLayout();
            this.PanelIme.ResumeLayout(false);
            this.PanelIme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMjesto;
        private System.Windows.Forms.Panel PanelUloga;
        private System.Windows.Forms.Label LblMjesto;
        private System.Windows.Forms.Panel PanelAdresa;
        private System.Windows.Forms.TextBox TxtAdresa;
        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Panel PanelOdjel;
        private System.Windows.Forms.Label LblUloga;
        private System.Windows.Forms.Panel PanelPoduzece;
        private System.Windows.Forms.Panel PanelLozinka;
        private System.Windows.Forms.Label LblPoduzece;
        private System.Windows.Forms.Button BtnIzmijeni;
        private System.Windows.Forms.Label LblLozinka;
        private System.Windows.Forms.Label LblOdjel;
        private System.Windows.Forms.Label LblAdresa;
        private System.Windows.Forms.Label LblBroj;
        private System.Windows.Forms.TextBox TxtBroj;
        private System.Windows.Forms.Panel PanelBroj;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Panel PanelEmail;
        private System.Windows.Forms.Label LblOib;
        private System.Windows.Forms.TextBox TxtOib;
        private System.Windows.Forms.Panel PanelOib;
        private System.Windows.Forms.Label LblPrezime;
        private System.Windows.Forms.TextBox TxtPrezime;
        private System.Windows.Forms.Panel PanelPrezime;
        private System.Windows.Forms.TextBox TxtIme;
        private System.Windows.Forms.Panel PanelIme;
        private System.Windows.Forms.Label LblIme;
        private System.Windows.Forms.ComboBox CboxGradovi;
        private System.Windows.Forms.ComboBox CboxUloge;
        private System.Windows.Forms.ComboBox CboxOdjeli;
        private System.Windows.Forms.ComboBox CboxPoduzeca;
        private System.Windows.Forms.TextBox TxtLozinka;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}