namespace HONING_App.Forme.Godišnji_odmori
{
    partial class ZahtjevGodisnjiOdmorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZahtjevGodisnjiOdmorForm));
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.LblKorisnik = new System.Windows.Forms.Label();
            this.LblDatumOd = new System.Windows.Forms.Label();
            this.LblDatumDo = new System.Windows.Forms.Label();
            this.DtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.DtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.BtnPosalji = new System.Windows.Forms.Button();
            this.LblPodaciKorisnika = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(121, 282);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(194, 30);
            this.BtnOdustani.TabIndex = 0;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // LblKorisnik
            // 
            this.LblKorisnik.AutoSize = true;
            this.LblKorisnik.Location = new System.Drawing.Point(27, 48);
            this.LblKorisnik.Name = "LblKorisnik";
            this.LblKorisnik.Size = new System.Drawing.Size(64, 20);
            this.LblKorisnik.TabIndex = 1;
            this.LblKorisnik.Text = "Korisnik:";
            // 
            // LblDatumOd
            // 
            this.LblDatumOd.AutoSize = true;
            this.LblDatumOd.Location = new System.Drawing.Point(27, 113);
            this.LblDatumOd.Name = "LblDatumOd";
            this.LblDatumOd.Size = new System.Drawing.Size(32, 20);
            this.LblDatumOd.TabIndex = 2;
            this.LblDatumOd.Text = "Od:";
            // 
            // LblDatumDo
            // 
            this.LblDatumDo.AutoSize = true;
            this.LblDatumDo.Location = new System.Drawing.Point(27, 168);
            this.LblDatumDo.Name = "LblDatumDo";
            this.LblDatumDo.Size = new System.Drawing.Size(32, 20);
            this.LblDatumDo.TabIndex = 3;
            this.LblDatumDo.Text = "Do:";
            // 
            // DtpDatumOd
            // 
            this.DtpDatumOd.Location = new System.Drawing.Point(121, 108);
            this.DtpDatumOd.Name = "DtpDatumOd";
            this.DtpDatumOd.Size = new System.Drawing.Size(194, 27);
            this.DtpDatumOd.TabIndex = 5;
            // 
            // DtpDatumDo
            // 
            this.DtpDatumDo.Location = new System.Drawing.Point(121, 165);
            this.DtpDatumDo.Name = "DtpDatumDo";
            this.DtpDatumDo.Size = new System.Drawing.Size(194, 27);
            this.DtpDatumDo.TabIndex = 6;
            // 
            // BtnPosalji
            // 
            this.BtnPosalji.Location = new System.Drawing.Point(121, 224);
            this.BtnPosalji.Name = "BtnPosalji";
            this.BtnPosalji.Size = new System.Drawing.Size(194, 52);
            this.BtnPosalji.TabIndex = 7;
            this.BtnPosalji.Text = "Pošalji zahtjev";
            this.BtnPosalji.UseVisualStyleBackColor = true;
            this.BtnPosalji.Click += new System.EventHandler(this.BtnPosalji_Click);
            // 
            // LblPodaciKorisnika
            // 
            this.LblPodaciKorisnika.AutoSize = true;
            this.LblPodaciKorisnika.Location = new System.Drawing.Point(121, 50);
            this.LblPodaciKorisnika.Name = "LblPodaciKorisnika";
            this.LblPodaciKorisnika.Size = new System.Drawing.Size(0, 20);
            this.LblPodaciKorisnika.TabIndex = 8;
            // 
            // ZahtjevGodisnjiOdmorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::HONING_App.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 374);
            this.Controls.Add(this.LblPodaciKorisnika);
            this.Controls.Add(this.BtnPosalji);
            this.Controls.Add(this.DtpDatumDo);
            this.Controls.Add(this.DtpDatumOd);
            this.Controls.Add(this.LblDatumDo);
            this.Controls.Add(this.LblDatumOd);
            this.Controls.Add(this.LblKorisnik);
            this.Controls.Add(this.BtnOdustani);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ZahtjevGodisnjiOdmorForm";
            this.Text = "ZahtjevGodisnjiOdmorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Label LblKorisnik;
        private System.Windows.Forms.Label LblDatumOd;
        private System.Windows.Forms.Label LblDatumDo;
        private System.Windows.Forms.DateTimePicker DtpDatumOd;
        private System.Windows.Forms.DateTimePicker DtpDatumDo;
        private System.Windows.Forms.Button BtnPosalji;
        private System.Windows.Forms.Label LblPodaciKorisnika;
    }
}