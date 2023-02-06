namespace HONING_App.Forme.Godišnji_odmori
{
    partial class GodisnjiOdmoriForm
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
            this.LblNaslov = new System.Windows.Forms.Label();
            this.BtnZahtjev = new System.Windows.Forms.Button();
            this.BtnPotvrdi = new System.Windows.Forms.Button();
            this.dgvGodisnjiOdmori = new System.Windows.Forms.DataGridView();
            this.BtnOdbij = new System.Windows.Forms.Button();
            this.DgvSviZahtjevi = new System.Windows.Forms.DataGridView();
            this.LblSviZahtjevi = new System.Windows.Forms.Label();
            this.DgvPrivaceniGO = new System.Windows.Forms.DataGridView();
            this.GbxKorisnikovOdmor = new System.Windows.Forms.GroupBox();
            this.TxtDatumDo = new System.Windows.Forms.TextBox();
            this.TxtDatumOd = new System.Windows.Forms.TextBox();
            this.LblDatumDo = new System.Windows.Forms.Label();
            this.LblDatumOd = new System.Windows.Forms.Label();
            this.KalendarGodisnjihOdmora = new System.Windows.Forms.MonthCalendar();
            this.LblNeobradeniZahtjevi = new System.Windows.Forms.Label();
            this.LblPopisGodisnjih = new System.Windows.Forms.Label();
            this.BtnUredi = new System.Windows.Forms.Button();
            this.GbxIzmjena = new System.Windows.Forms.GroupBox();
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.RbOdbijeno = new System.Windows.Forms.RadioButton();
            this.RbPrihvaceno = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblKalkulatorGodisnjeg = new System.Windows.Forms.Label();
            this.LblUkupnoBroj = new System.Windows.Forms.Label();
            this.LblUkupno = new System.Windows.Forms.Label();
            this.LblIskoristenoBroj = new System.Windows.Forms.Label();
            this.LblIskoristeno = new System.Windows.Forms.Label();
            this.LblPreostalo = new System.Windows.Forms.Label();
            this.LblPreostaloBroj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodisnjiOdmori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSviZahtjevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrivaceniGO)).BeginInit();
            this.GbxKorisnikovOdmor.SuspendLayout();
            this.GbxIzmjena.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblNaslov
            // 
            this.LblNaslov.AutoSize = true;
            this.LblNaslov.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblNaslov.Location = new System.Drawing.Point(13, 25);
            this.LblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNaslov.Name = "LblNaslov";
            this.LblNaslov.Size = new System.Drawing.Size(254, 37);
            this.LblNaslov.TabIndex = 13;
            this.LblNaslov.Text = "GODIŠNJI ODMORI";
            // 
            // BtnZahtjev
            // 
            this.BtnZahtjev.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnZahtjev.Location = new System.Drawing.Point(685, 385);
            this.BtnZahtjev.Name = "BtnZahtjev";
            this.BtnZahtjev.Size = new System.Drawing.Size(170, 61);
            this.BtnZahtjev.TabIndex = 14;
            this.BtnZahtjev.Text = "Izradi zahtjev za godišnjim odmorom";
            this.BtnZahtjev.UseVisualStyleBackColor = true;
            this.BtnZahtjev.Click += new System.EventHandler(this.BtnZahtjev_Click);
            // 
            // BtnPotvrdi
            // 
            this.BtnPotvrdi.Location = new System.Drawing.Point(486, 336);
            this.BtnPotvrdi.Name = "BtnPotvrdi";
            this.BtnPotvrdi.Size = new System.Drawing.Size(161, 39);
            this.BtnPotvrdi.TabIndex = 16;
            this.BtnPotvrdi.Text = "Prihvati zahtjev";
            this.BtnPotvrdi.UseVisualStyleBackColor = true;
            this.BtnPotvrdi.Click += new System.EventHandler(this.BtnPotvrdi_Click);
            // 
            // dgvGodisnjiOdmori
            // 
            this.dgvGodisnjiOdmori.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGodisnjiOdmori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGodisnjiOdmori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGodisnjiOdmori.Location = new System.Drawing.Point(51, 104);
            this.dgvGodisnjiOdmori.Name = "dgvGodisnjiOdmori";
            this.dgvGodisnjiOdmori.RowHeadersWidth = 51;
            this.dgvGodisnjiOdmori.RowTemplate.Height = 24;
            this.dgvGodisnjiOdmori.Size = new System.Drawing.Size(596, 226);
            this.dgvGodisnjiOdmori.TabIndex = 17;
            // 
            // BtnOdbij
            // 
            this.BtnOdbij.Location = new System.Drawing.Point(486, 381);
            this.BtnOdbij.Name = "BtnOdbij";
            this.BtnOdbij.Size = new System.Drawing.Size(161, 39);
            this.BtnOdbij.TabIndex = 18;
            this.BtnOdbij.Text = "Odbij zahtjev";
            this.BtnOdbij.UseVisualStyleBackColor = true;
            this.BtnOdbij.Click += new System.EventHandler(this.BtnOdbij_Click);
            // 
            // DgvSviZahtjevi
            // 
            this.DgvSviZahtjevi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvSviZahtjevi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvSviZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSviZahtjevi.Location = new System.Drawing.Point(51, 447);
            this.DgvSviZahtjevi.Name = "DgvSviZahtjevi";
            this.DgvSviZahtjevi.RowHeadersWidth = 51;
            this.DgvSviZahtjevi.RowTemplate.Height = 24;
            this.DgvSviZahtjevi.Size = new System.Drawing.Size(850, 240);
            this.DgvSviZahtjevi.TabIndex = 19;
            // 
            // LblSviZahtjevi
            // 
            this.LblSviZahtjevi.AutoSize = true;
            this.LblSviZahtjevi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblSviZahtjevi.Location = new System.Drawing.Point(47, 424);
            this.LblSviZahtjevi.Name = "LblSviZahtjevi";
            this.LblSviZahtjevi.Size = new System.Drawing.Size(361, 20);
            this.LblSviZahtjevi.TabIndex = 20;
            this.LblSviZahtjevi.Text = "Prihvaćeni i odbijeni zahtjevi za godišnjim odmorom:";
            // 
            // DgvPrivaceniGO
            // 
            this.DgvPrivaceniGO.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvPrivaceniGO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPrivaceniGO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrivaceniGO.Location = new System.Drawing.Point(51, 104);
            this.DgvPrivaceniGO.Name = "DgvPrivaceniGO";
            this.DgvPrivaceniGO.RowHeadersWidth = 51;
            this.DgvPrivaceniGO.RowTemplate.Height = 24;
            this.DgvPrivaceniGO.Size = new System.Drawing.Size(596, 226);
            this.DgvPrivaceniGO.TabIndex = 21;
            this.DgvPrivaceniGO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrivaceniGO_CellContentClick);
            // 
            // GbxKorisnikovOdmor
            // 
            this.GbxKorisnikovOdmor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GbxKorisnikovOdmor.Controls.Add(this.TxtDatumDo);
            this.GbxKorisnikovOdmor.Controls.Add(this.TxtDatumOd);
            this.GbxKorisnikovOdmor.Controls.Add(this.LblDatumDo);
            this.GbxKorisnikovOdmor.Controls.Add(this.LblDatumOd);
            this.GbxKorisnikovOdmor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GbxKorisnikovOdmor.Location = new System.Drawing.Point(51, 344);
            this.GbxKorisnikovOdmor.Name = "GbxKorisnikovOdmor";
            this.GbxKorisnikovOdmor.Size = new System.Drawing.Size(480, 76);
            this.GbxKorisnikovOdmor.TabIndex = 22;
            this.GbxKorisnikovOdmor.TabStop = false;
            this.GbxKorisnikovOdmor.Text = "Vaš godišnji odmor:";
            // 
            // TxtDatumDo
            // 
            this.TxtDatumDo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDatumDo.Location = new System.Drawing.Point(357, 36);
            this.TxtDatumDo.Name = "TxtDatumDo";
            this.TxtDatumDo.Size = new System.Drawing.Size(100, 30);
            this.TxtDatumDo.TabIndex = 26;
            // 
            // TxtDatumOd
            // 
            this.TxtDatumOd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDatumOd.Location = new System.Drawing.Point(118, 36);
            this.TxtDatumOd.Name = "TxtDatumOd";
            this.TxtDatumOd.Size = new System.Drawing.Size(100, 30);
            this.TxtDatumOd.TabIndex = 25;
            // 
            // LblDatumDo
            // 
            this.LblDatumDo.AutoSize = true;
            this.LblDatumDo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LblDatumDo.Location = new System.Drawing.Point(257, 41);
            this.LblDatumDo.Name = "LblDatumDo";
            this.LblDatumDo.Size = new System.Drawing.Size(81, 20);
            this.LblDatumDo.TabIndex = 24;
            this.LblDatumDo.Text = "Datum do:";
            // 
            // LblDatumOd
            // 
            this.LblDatumOd.AutoSize = true;
            this.LblDatumOd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.LblDatumOd.Location = new System.Drawing.Point(31, 41);
            this.LblDatumOd.Name = "LblDatumOd";
            this.LblDatumOd.Size = new System.Drawing.Size(81, 20);
            this.LblDatumOd.TabIndex = 23;
            this.LblDatumOd.Text = "Datum od:";
            // 
            // KalendarGodisnjihOdmora
            // 
            this.KalendarGodisnjihOdmora.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KalendarGodisnjihOdmora.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.KalendarGodisnjihOdmora.Location = new System.Drawing.Point(51, 432);
            this.KalendarGodisnjihOdmora.MinDate = new System.DateTime(2021, 6, 12, 0, 0, 0, 0);
            this.KalendarGodisnjihOdmora.Name = "KalendarGodisnjihOdmora";
            this.KalendarGodisnjihOdmora.TabIndex = 23;
            this.KalendarGodisnjihOdmora.TitleBackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // LblNeobradeniZahtjevi
            // 
            this.LblNeobradeniZahtjevi.AutoSize = true;
            this.LblNeobradeniZahtjevi.Location = new System.Drawing.Point(47, 81);
            this.LblNeobradeniZahtjevi.Name = "LblNeobradeniZahtjevi";
            this.LblNeobradeniZahtjevi.Size = new System.Drawing.Size(146, 20);
            this.LblNeobradeniZahtjevi.TabIndex = 24;
            this.LblNeobradeniZahtjevi.Text = "Neobrađeni zahtjevi:";
            // 
            // LblPopisGodisnjih
            // 
            this.LblPopisGodisnjih.AutoSize = true;
            this.LblPopisGodisnjih.Location = new System.Drawing.Point(47, 81);
            this.LblPopisGodisnjih.Name = "LblPopisGodisnjih";
            this.LblPopisGodisnjih.Size = new System.Drawing.Size(252, 20);
            this.LblPopisGodisnjih.TabIndex = 25;
            this.LblPopisGodisnjih.Text = "Popis zabilježenih godišnjih odmora:";
            // 
            // BtnUredi
            // 
            this.BtnUredi.Location = new System.Drawing.Point(907, 449);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(136, 64);
            this.BtnUredi.TabIndex = 26;
            this.BtnUredi.Text = "Izmijeni zahtjev";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // GbxIzmjena
            // 
            this.GbxIzmjena.Controls.Add(this.BtnOdustani);
            this.GbxIzmjena.Controls.Add(this.BtnSpremi);
            this.GbxIzmjena.Controls.Add(this.RbOdbijeno);
            this.GbxIzmjena.Controls.Add(this.RbPrihvaceno);
            this.GbxIzmjena.Location = new System.Drawing.Point(907, 528);
            this.GbxIzmjena.Name = "GbxIzmjena";
            this.GbxIzmjena.Size = new System.Drawing.Size(209, 133);
            this.GbxIzmjena.TabIndex = 27;
            this.GbxIzmjena.TabStop = false;
            this.GbxIzmjena.Text = "Izmjena zahtjeva";
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(107, 95);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(95, 32);
            this.BtnOdustani.TabIndex = 29;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.Location = new System.Drawing.Point(6, 95);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(95, 32);
            this.BtnSpremi.TabIndex = 28;
            this.BtnSpremi.Text = "Spremi";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // RbOdbijeno
            // 
            this.RbOdbijeno.AutoSize = true;
            this.RbOdbijeno.Location = new System.Drawing.Point(31, 57);
            this.RbOdbijeno.Name = "RbOdbijeno";
            this.RbOdbijeno.Size = new System.Drawing.Size(92, 24);
            this.RbOdbijeno.TabIndex = 1;
            this.RbOdbijeno.TabStop = true;
            this.RbOdbijeno.Text = "Odbijeno";
            this.RbOdbijeno.UseVisualStyleBackColor = true;
            // 
            // RbPrihvaceno
            // 
            this.RbPrihvaceno.AutoSize = true;
            this.RbPrihvaceno.Location = new System.Drawing.Point(31, 27);
            this.RbPrihvaceno.Name = "RbPrihvaceno";
            this.RbPrihvaceno.Size = new System.Drawing.Size(102, 24);
            this.RbPrihvaceno.TabIndex = 0;
            this.RbPrihvaceno.TabStop = true;
            this.RbPrihvaceno.Text = "Prihvaćeno";
            this.RbPrihvaceno.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblPreostaloBroj);
            this.panel1.Controls.Add(this.LblPreostalo);
            this.panel1.Controls.Add(this.LblIskoristeno);
            this.panel1.Controls.Add(this.LblIskoristenoBroj);
            this.panel1.Controls.Add(this.LblUkupno);
            this.panel1.Controls.Add(this.LblUkupnoBroj);
            this.panel1.Controls.Add(this.LblKalkulatorGodisnjeg);
            this.panel1.Location = new System.Drawing.Point(685, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 274);
            this.panel1.TabIndex = 28;
            // 
            // LblKalkulatorGodisnjeg
            // 
            this.LblKalkulatorGodisnjeg.AutoSize = true;
            this.LblKalkulatorGodisnjeg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblKalkulatorGodisnjeg.Location = new System.Drawing.Point(43, 22);
            this.LblKalkulatorGodisnjeg.Name = "LblKalkulatorGodisnjeg";
            this.LblKalkulatorGodisnjeg.Size = new System.Drawing.Size(79, 20);
            this.LblKalkulatorGodisnjeg.TabIndex = 0;
            this.LblKalkulatorGodisnjeg.Text = "GODIŠNJI";
            this.LblKalkulatorGodisnjeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUkupnoBroj
            // 
            this.LblUkupnoBroj.AutoSize = true;
            this.LblUkupnoBroj.Location = new System.Drawing.Point(72, 79);
            this.LblUkupnoBroj.Name = "LblUkupnoBroj";
            this.LblUkupnoBroj.Size = new System.Drawing.Size(25, 20);
            this.LblUkupnoBroj.TabIndex = 1;
            this.LblUkupnoBroj.Text = "28";
            this.LblUkupnoBroj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblUkupno
            // 
            this.LblUkupno.AutoSize = true;
            this.LblUkupno.Location = new System.Drawing.Point(48, 59);
            this.LblUkupno.Name = "LblUkupno";
            this.LblUkupno.Size = new System.Drawing.Size(68, 20);
            this.LblUkupno.TabIndex = 2;
            this.LblUkupno.Text = "UKUPNO";
            this.LblUkupno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblIskoristenoBroj
            // 
            this.LblIskoristenoBroj.AutoSize = true;
            this.LblIskoristenoBroj.Location = new System.Drawing.Point(72, 148);
            this.LblIskoristenoBroj.Name = "LblIskoristenoBroj";
            this.LblIskoristenoBroj.Size = new System.Drawing.Size(25, 20);
            this.LblIskoristenoBroj.TabIndex = 3;
            this.LblIskoristenoBroj.Text = "13";
            this.LblIskoristenoBroj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblIskoristeno
            // 
            this.LblIskoristeno.AutoSize = true;
            this.LblIskoristeno.Location = new System.Drawing.Point(41, 128);
            this.LblIskoristeno.Name = "LblIskoristeno";
            this.LblIskoristeno.Size = new System.Drawing.Size(99, 20);
            this.LblIskoristeno.TabIndex = 4;
            this.LblIskoristeno.Text = "ISKORIŠTENO";
            this.LblIskoristeno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPreostalo
            // 
            this.LblPreostalo.AutoSize = true;
            this.LblPreostalo.Location = new System.Drawing.Point(41, 198);
            this.LblPreostalo.Name = "LblPreostalo";
            this.LblPreostalo.Size = new System.Drawing.Size(87, 20);
            this.LblPreostalo.TabIndex = 5;
            this.LblPreostalo.Text = "PREOSTALO";
            this.LblPreostalo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPreostaloBroj
            // 
            this.LblPreostaloBroj.AutoSize = true;
            this.LblPreostaloBroj.Location = new System.Drawing.Point(72, 224);
            this.LblPreostaloBroj.Name = "LblPreostaloBroj";
            this.LblPreostaloBroj.Size = new System.Drawing.Size(25, 20);
            this.LblPreostaloBroj.TabIndex = 6;
            this.LblPreostaloBroj.Text = "15";
            this.LblPreostaloBroj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GodisnjiOdmoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::HONING_App.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 734);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GbxIzmjena);
            this.Controls.Add(this.BtnUredi);
            this.Controls.Add(this.LblPopisGodisnjih);
            this.Controls.Add(this.LblNeobradeniZahtjevi);
            this.Controls.Add(this.KalendarGodisnjihOdmora);
            this.Controls.Add(this.GbxKorisnikovOdmor);
            this.Controls.Add(this.BtnZahtjev);
            this.Controls.Add(this.DgvPrivaceniGO);
            this.Controls.Add(this.LblSviZahtjevi);
            this.Controls.Add(this.BtnPotvrdi);
            this.Controls.Add(this.DgvSviZahtjevi);
            this.Controls.Add(this.BtnOdbij);
            this.Controls.Add(this.dgvGodisnjiOdmori);
            this.Controls.Add(this.LblNaslov);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GodisnjiOdmoriForm";
            this.Text = "GodisnjiOdmoriForm";
            this.Load += new System.EventHandler(this.GodisnjiOdmoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodisnjiOdmori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSviZahtjevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrivaceniGO)).EndInit();
            this.GbxKorisnikovOdmor.ResumeLayout(false);
            this.GbxKorisnikovOdmor.PerformLayout();
            this.GbxIzmjena.ResumeLayout(false);
            this.GbxIzmjena.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNaslov;
        private System.Windows.Forms.Button BtnZahtjev;
        private System.Windows.Forms.Button BtnPotvrdi;
        private System.Windows.Forms.DataGridView dgvGodisnjiOdmori;
        private System.Windows.Forms.Button BtnOdbij;
        private System.Windows.Forms.DataGridView DgvSviZahtjevi;
        private System.Windows.Forms.Label LblSviZahtjevi;
        private System.Windows.Forms.DataGridView DgvPrivaceniGO;
        private System.Windows.Forms.GroupBox GbxKorisnikovOdmor;
        private System.Windows.Forms.TextBox TxtDatumDo;
        private System.Windows.Forms.TextBox TxtDatumOd;
        private System.Windows.Forms.Label LblDatumDo;
        private System.Windows.Forms.Label LblDatumOd;
        private System.Windows.Forms.MonthCalendar KalendarGodisnjihOdmora;
        private System.Windows.Forms.Label LblNeobradeniZahtjevi;
        private System.Windows.Forms.Label LblPopisGodisnjih;
        private System.Windows.Forms.Button BtnUredi;
        private System.Windows.Forms.GroupBox GbxIzmjena;
        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Button BtnSpremi;
        private System.Windows.Forms.RadioButton RbOdbijeno;
        private System.Windows.Forms.RadioButton RbPrihvaceno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPreostaloBroj;
        private System.Windows.Forms.Label LblPreostalo;
        private System.Windows.Forms.Label LblIskoristeno;
        private System.Windows.Forms.Label LblIskoristenoBroj;
        private System.Windows.Forms.Label LblUkupno;
        private System.Windows.Forms.Label LblUkupnoBroj;
        private System.Windows.Forms.Label LblKalkulatorGodisnjeg;
    }
}