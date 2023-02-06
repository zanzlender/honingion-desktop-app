
namespace HONING_App.Forme.Home
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.PanelIzbornik = new System.Windows.Forms.Panel();
            this.BtnLogut = new FontAwesome.Sharp.IconButton();
            this.BtnDodajPoduzece = new FontAwesome.Sharp.IconButton();
            this.BtnBazaZaposlenika = new FontAwesome.Sharp.IconButton();
            this.BtnStatistika = new FontAwesome.Sharp.IconButton();
            this.BtnSkladiste = new FontAwesome.Sharp.IconButton();
            this.BtnProdaja = new FontAwesome.Sharp.IconButton();
            this.BtnGodisnji = new FontAwesome.Sharp.IconButton();
            this.BtnRaspored = new FontAwesome.Sharp.IconButton();
            this.BtnNovosti = new FontAwesome.Sharp.IconButton();
            this.PanelEmpty = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new HONING_App.Controls.GradientPanel();
            this.TxtUloga = new System.Windows.Forms.RichTextBox();
            this.TxtImePrezime = new System.Windows.Forms.RichTextBox();
            this.SlikaProfilaUC1 = new HONING_App.Forme.Home.SlikaProfilaUC();
            this.PanelParent = new System.Windows.Forms.Panel();
            this.PanelIzbornik.SuspendLayout();
            this.PanelEmpty.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelIzbornik
            // 
            this.PanelIzbornik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelIzbornik.Controls.Add(this.BtnLogut);
            this.PanelIzbornik.Controls.Add(this.BtnDodajPoduzece);
            this.PanelIzbornik.Controls.Add(this.BtnBazaZaposlenika);
            this.PanelIzbornik.Controls.Add(this.BtnStatistika);
            this.PanelIzbornik.Controls.Add(this.BtnSkladiste);
            this.PanelIzbornik.Controls.Add(this.BtnProdaja);
            this.PanelIzbornik.Controls.Add(this.BtnGodisnji);
            this.PanelIzbornik.Controls.Add(this.BtnRaspored);
            this.PanelIzbornik.Controls.Add(this.BtnNovosti);
            this.PanelIzbornik.Controls.Add(this.PanelEmpty);
            this.PanelIzbornik.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzbornik.Location = new System.Drawing.Point(0, 0);
            this.PanelIzbornik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelIzbornik.Name = "PanelIzbornik";
            this.PanelIzbornik.Size = new System.Drawing.Size(305, 753);
            this.PanelIzbornik.TabIndex = 2;
            // 
            // BtnLogut
            // 
            this.BtnLogut.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(87)))));
            this.BtnLogut.FlatAppearance.BorderSize = 0;
            this.BtnLogut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnLogut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLogut.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.BtnLogut.IconColor = System.Drawing.Color.DimGray;
            this.BtnLogut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogut.IconSize = 20;
            this.BtnLogut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogut.Location = new System.Drawing.Point(0, 484);
            this.BtnLogut.Name = "BtnLogut";
            this.BtnLogut.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnLogut.Size = new System.Drawing.Size(229, 40);
            this.BtnLogut.TabIndex = 15;
            this.BtnLogut.Text = "  ODJAVA";
            this.BtnLogut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogut.UseVisualStyleBackColor = true;
            this.BtnLogut.Visible = false;
            this.BtnLogut.Click += new System.EventHandler(this.BtnLogut_Click);
            // 
            // BtnDodajPoduzece
            // 
            this.BtnDodajPoduzece.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDodajPoduzece.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(87)))));
            this.BtnDodajPoduzece.FlatAppearance.BorderSize = 0;
            this.BtnDodajPoduzece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDodajPoduzece.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodajPoduzece.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnDodajPoduzece.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.BtnDodajPoduzece.IconColor = System.Drawing.Color.Gray;
            this.BtnDodajPoduzece.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDodajPoduzece.IconSize = 20;
            this.BtnDodajPoduzece.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDodajPoduzece.Location = new System.Drawing.Point(0, 545);
            this.BtnDodajPoduzece.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDodajPoduzece.Name = "BtnDodajPoduzece";
            this.BtnDodajPoduzece.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.BtnDodajPoduzece.Size = new System.Drawing.Size(305, 49);
            this.BtnDodajPoduzece.TabIndex = 13;
            this.BtnDodajPoduzece.Text = "  DODAJ PODUZEĆE";
            this.BtnDodajPoduzece.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDodajPoduzece.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDodajPoduzece.UseVisualStyleBackColor = true;
            this.BtnDodajPoduzece.Visible = false;
            this.BtnDodajPoduzece.Click += new System.EventHandler(this.BtnDodajPoduzece_Click);
            // 
            // BtnBazaZaposlenika
            // 
            this.BtnBazaZaposlenika.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBazaZaposlenika.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(87)))));
            this.BtnBazaZaposlenika.FlatAppearance.BorderSize = 0;
            this.BtnBazaZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBazaZaposlenika.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnBazaZaposlenika.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnBazaZaposlenika.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.BtnBazaZaposlenika.IconColor = System.Drawing.Color.Gray;
            this.BtnBazaZaposlenika.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBazaZaposlenika.IconSize = 20;
            this.BtnBazaZaposlenika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBazaZaposlenika.Location = new System.Drawing.Point(0, 496);
            this.BtnBazaZaposlenika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBazaZaposlenika.Name = "BtnBazaZaposlenika";
            this.BtnBazaZaposlenika.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.BtnBazaZaposlenika.Size = new System.Drawing.Size(305, 49);
            this.BtnBazaZaposlenika.TabIndex = 11;
            this.BtnBazaZaposlenika.Text = "  BAZA ZAPOSLENIKA";
            this.BtnBazaZaposlenika.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBazaZaposlenika.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBazaZaposlenika.UseVisualStyleBackColor = true;
            this.BtnBazaZaposlenika.Visible = false;
            this.BtnBazaZaposlenika.Click += new System.EventHandler(this.BtnBazaZaposlenika_Click);
            // 
            // BtnStatistika
            // 
            this.BtnStatistika.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStatistika.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(87)))));
            this.BtnStatistika.FlatAppearance.BorderSize = 0;
            this.BtnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStatistika.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnStatistika.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnStatistika.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.BtnStatistika.IconColor = System.Drawing.Color.Gray;
            this.BtnStatistika.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnStatistika.IconSize = 20;
            this.BtnStatistika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStatistika.Location = new System.Drawing.Point(0, 447);
            this.BtnStatistika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnStatistika.Name = "BtnStatistika";
            this.BtnStatistika.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.BtnStatistika.Size = new System.Drawing.Size(305, 49);
            this.BtnStatistika.TabIndex = 10;
            this.BtnStatistika.Text = "  STATISTIKA";
            this.BtnStatistika.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStatistika.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStatistika.UseVisualStyleBackColor = true;
            this.BtnStatistika.Visible = false;
            this.BtnStatistika.Click += new System.EventHandler(this.BtnStatistika_Click);
            // 
            // BtnSkladiste
            // 
            this.BtnSkladiste.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSkladiste.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(87)))));
            this.BtnSkladiste.FlatAppearance.BorderSize = 0;
            this.BtnSkladiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSkladiste.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSkladiste.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSkladiste.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.BtnSkladiste.IconColor = System.Drawing.Color.Gray;
            this.BtnSkladiste.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSkladiste.IconSize = 20;
            this.BtnSkladiste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSkladiste.Location = new System.Drawing.Point(0, 398);
            this.BtnSkladiste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSkladiste.Name = "BtnSkladiste";
            this.BtnSkladiste.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.BtnSkladiste.Size = new System.Drawing.Size(305, 49);
            this.BtnSkladiste.TabIndex = 9;
            this.BtnSkladiste.Text = "  SKLADIŠTE";
            this.BtnSkladiste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSkladiste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSkladiste.UseVisualStyleBackColor = true;
            this.BtnSkladiste.Visible = false;
            this.BtnSkladiste.Click += new System.EventHandler(this.BtnSkladiste_Click);
            // 
            // BtnProdaja
            // 
            this.BtnProdaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProdaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(87)))));
            this.BtnProdaja.FlatAppearance.BorderSize = 0;
            this.BtnProdaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProdaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnProdaja.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnProdaja.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.BtnProdaja.IconColor = System.Drawing.Color.Gray;
            this.BtnProdaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProdaja.IconSize = 20;
            this.BtnProdaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdaja.Location = new System.Drawing.Point(0, 349);
            this.BtnProdaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnProdaja.Name = "BtnProdaja";
            this.BtnProdaja.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.BtnProdaja.Size = new System.Drawing.Size(305, 49);
            this.BtnProdaja.TabIndex = 8;
            this.BtnProdaja.Text = "  PRODAJA";
            this.BtnProdaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProdaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProdaja.UseVisualStyleBackColor = true;
            this.BtnProdaja.Visible = false;
            this.BtnProdaja.Click += new System.EventHandler(this.BtnProdaja_Click);
            // 
            // BtnGodisnji
            // 
            this.BtnGodisnji.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGodisnji.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(87)))));
            this.BtnGodisnji.FlatAppearance.BorderSize = 0;
            this.BtnGodisnji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGodisnji.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnGodisnji.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGodisnji.IconChar = FontAwesome.Sharp.IconChar.SuitcaseRolling;
            this.BtnGodisnji.IconColor = System.Drawing.Color.Gray;
            this.BtnGodisnji.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnGodisnji.IconSize = 20;
            this.BtnGodisnji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGodisnji.Location = new System.Drawing.Point(0, 300);
            this.BtnGodisnji.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGodisnji.Name = "BtnGodisnji";
            this.BtnGodisnji.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.BtnGodisnji.Size = new System.Drawing.Size(305, 49);
            this.BtnGodisnji.TabIndex = 7;
            this.BtnGodisnji.Text = "  GODIŠNJI ODMOR";
            this.BtnGodisnji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGodisnji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnGodisnji.UseVisualStyleBackColor = true;
            this.BtnGodisnji.Visible = false;
            this.BtnGodisnji.Click += new System.EventHandler(this.BtnGodisnji_Click);
            // 
            // BtnRaspored
            // 
            this.BtnRaspored.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRaspored.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(87)))));
            this.BtnRaspored.FlatAppearance.BorderSize = 0;
            this.BtnRaspored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRaspored.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnRaspored.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRaspored.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.BtnRaspored.IconColor = System.Drawing.Color.Gray;
            this.BtnRaspored.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRaspored.IconSize = 20;
            this.BtnRaspored.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRaspored.Location = new System.Drawing.Point(0, 251);
            this.BtnRaspored.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRaspored.Name = "BtnRaspored";
            this.BtnRaspored.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.BtnRaspored.Size = new System.Drawing.Size(305, 49);
            this.BtnRaspored.TabIndex = 6;
            this.BtnRaspored.Text = "  RASPORED";
            this.BtnRaspored.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRaspored.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRaspored.UseVisualStyleBackColor = true;
            this.BtnRaspored.Visible = false;
            this.BtnRaspored.Click += new System.EventHandler(this.BtnRaspored_Click);
            // 
            // BtnNovosti
            // 
            this.BtnNovosti.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnNovosti.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNovosti.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(87)))));
            this.BtnNovosti.FlatAppearance.BorderSize = 0;
            this.BtnNovosti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovosti.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnNovosti.ForeColor = System.Drawing.Color.Gray;
            this.BtnNovosti.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText;
            this.BtnNovosti.IconColor = System.Drawing.Color.Gray;
            this.BtnNovosti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNovosti.IconSize = 20;
            this.BtnNovosti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovosti.Location = new System.Drawing.Point(0, 202);
            this.BtnNovosti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNovosti.Name = "BtnNovosti";
            this.BtnNovosti.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.BtnNovosti.Size = new System.Drawing.Size(305, 49);
            this.BtnNovosti.TabIndex = 5;
            this.BtnNovosti.Text = "  NOVOSTI I OBAVIJESTI";
            this.BtnNovosti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovosti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNovosti.UseVisualStyleBackColor = false;
            this.BtnNovosti.Visible = false;
            this.BtnNovosti.Click += new System.EventHandler(this.BtnNovosti_Click);
            // 
            // PanelEmpty
            // 
            this.PanelEmpty.Controls.Add(this.gradientPanel1);
            this.PanelEmpty.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEmpty.Location = new System.Drawing.Point(0, 0);
            this.PanelEmpty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelEmpty.Name = "PanelEmpty";
            this.PanelEmpty.Size = new System.Drawing.Size(305, 202);
            this.PanelEmpty.TabIndex = 14;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(218)))), ((int)(((byte)(97)))));
            this.gradientPanel1.Controls.Add(this.TxtUloga);
            this.gradientPanel1.Controls.Add(this.TxtImePrezime);
            this.gradientPanel1.Controls.Add(this.SlikaProfilaUC1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(305, 188);
            this.gradientPanel1.TabIndex = 0;
            // 
            // TxtUloga
            // 
            this.TxtUloga.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtUloga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUloga.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtUloga.ForeColor = System.Drawing.Color.Black;
            this.TxtUloga.Location = new System.Drawing.Point(51, 145);
            this.TxtUloga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUloga.Multiline = false;
            this.TxtUloga.Name = "TxtUloga";
            this.TxtUloga.ReadOnly = true;
            this.TxtUloga.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TxtUloga.Size = new System.Drawing.Size(203, 23);
            this.TxtUloga.TabIndex = 4;
            this.TxtUloga.Text = "SUPERADMINISTRATOR";
            // 
            // TxtImePrezime
            // 
            this.TxtImePrezime.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtImePrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtImePrezime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtImePrezime.ForeColor = System.Drawing.Color.Black;
            this.TxtImePrezime.Location = new System.Drawing.Point(12, 111);
            this.TxtImePrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtImePrezime.Multiline = false;
            this.TxtImePrezime.Name = "TxtImePrezime";
            this.TxtImePrezime.ReadOnly = true;
            this.TxtImePrezime.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TxtImePrezime.Size = new System.Drawing.Size(280, 27);
            this.TxtImePrezime.TabIndex = 5;
            this.TxtImePrezime.Text = "IME PREZIME";
            // 
            // SlikaProfilaUC1
            // 
            this.SlikaProfilaUC1.BackColor = System.Drawing.Color.Transparent;
            this.SlikaProfilaUC1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.SlikaProfilaUC1.Location = new System.Drawing.Point(105, 17);
            this.SlikaProfilaUC1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SlikaProfilaUC1.Name = "SlikaProfilaUC1";
            this.SlikaProfilaUC1.Size = new System.Drawing.Size(93, 86);
            this.SlikaProfilaUC1.TabIndex = 3;
            // 
            // PanelParent
            // 
            this.PanelParent.BackColor = System.Drawing.Color.White;
            this.PanelParent.BackgroundImage = global::HONING_App.Properties.Resources.pozadina;
            this.PanelParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelParent.Location = new System.Drawing.Point(229, 0);
            this.PanelParent.Name = "PanelParent";
            this.PanelParent.Size = new System.Drawing.Size(858, 612);
            this.PanelParent.TabIndex = 3;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 753);
            this.Controls.Add(this.PanelParent);
            this.Controls.Add(this.PanelIzbornik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(994, 605);
            this.Name = "HomeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.HomeForm_HelpRequested);
            this.PanelIzbornik.ResumeLayout(false);
            this.PanelEmpty.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelIzbornik;
        private System.Windows.Forms.Panel PanelParent;
        private FontAwesome.Sharp.IconButton BtnNovosti;
        private FontAwesome.Sharp.IconButton BtnDodajPoduzece;
        private FontAwesome.Sharp.IconButton BtnBazaZaposlenika;
        private FontAwesome.Sharp.IconButton BtnStatistika;
        private FontAwesome.Sharp.IconButton BtnSkladiste;
        private FontAwesome.Sharp.IconButton BtnProdaja;
        private FontAwesome.Sharp.IconButton BtnGodisnji;
        private FontAwesome.Sharp.IconButton BtnRaspored;
        private System.Windows.Forms.Panel PanelEmpty;
        private Controls.GradientPanel gradientPanel1;
        private System.Windows.Forms.RichTextBox TxtUloga;
        private System.Windows.Forms.RichTextBox TxtImePrezime;
        private SlikaProfilaUC SlikaProfilaUC1;
        private FontAwesome.Sharp.IconButton BtnLogut;
    }
}