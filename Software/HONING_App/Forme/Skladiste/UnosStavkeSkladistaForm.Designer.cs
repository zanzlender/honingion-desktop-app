namespace HONING_App.Forme.Skladiste
{
    partial class UnosStavkeSkladistaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.GbxVrstaStavke = new System.Windows.Forms.GroupBox();
            this.RbProizvod = new System.Windows.Forms.RadioButton();
            this.RbMaterijal = new System.Windows.Forms.RadioButton();
            this.LblNaziv = new System.Windows.Forms.Label();
            this.CmbNaziv = new System.Windows.Forms.ComboBox();
            this.LblKolicina = new System.Windows.Forms.Label();
            this.TxtKolicina = new System.Windows.Forms.TextBox();
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.GbxVrstaStavke.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // GbxVrstaStavke
            // 
            this.GbxVrstaStavke.Controls.Add(this.RbMaterijal);
            this.GbxVrstaStavke.Controls.Add(this.RbProizvod);
            this.GbxVrstaStavke.Location = new System.Drawing.Point(24, 25);
            this.GbxVrstaStavke.Name = "GbxVrstaStavke";
            this.GbxVrstaStavke.Size = new System.Drawing.Size(337, 66);
            this.GbxVrstaStavke.TabIndex = 1;
            this.GbxVrstaStavke.TabStop = false;
            this.GbxVrstaStavke.Text = "Vrsta stavke";
            // 
            // RbProizvod
            // 
            this.RbProizvod.AutoSize = true;
            this.RbProizvod.Location = new System.Drawing.Point(13, 26);
            this.RbProizvod.Name = "RbProizvod";
            this.RbProizvod.Size = new System.Drawing.Size(88, 24);
            this.RbProizvod.TabIndex = 2;
            this.RbProizvod.TabStop = true;
            this.RbProizvod.Text = "Proizvod";
            this.RbProizvod.UseVisualStyleBackColor = true;
            this.RbProizvod.CheckedChanged += new System.EventHandler(this.RbProizvod_CheckedChanged);
            // 
            // RbMaterijal
            // 
            this.RbMaterijal.AutoSize = true;
            this.RbMaterijal.Location = new System.Drawing.Point(147, 26);
            this.RbMaterijal.Name = "RbMaterijal";
            this.RbMaterijal.Size = new System.Drawing.Size(160, 24);
            this.RbMaterijal.TabIndex = 3;
            this.RbMaterijal.TabStop = true;
            this.RbMaterijal.Text = "Materijal ili sirovina";
            this.RbMaterijal.UseVisualStyleBackColor = true;
            this.RbMaterijal.CheckedChanged += new System.EventHandler(this.RbMaterijal_CheckedChanged);
            // 
            // LblNaziv
            // 
            this.LblNaziv.AutoSize = true;
            this.LblNaziv.Location = new System.Drawing.Point(20, 105);
            this.LblNaziv.Name = "LblNaziv";
            this.LblNaziv.Size = new System.Drawing.Size(94, 20);
            this.LblNaziv.TabIndex = 2;
            this.LblNaziv.Text = "Naziv stavke:";
            // 
            // CmbNaziv
            // 
            this.CmbNaziv.FormattingEnabled = true;
            this.CmbNaziv.Location = new System.Drawing.Point(138, 102);
            this.CmbNaziv.Name = "CmbNaziv";
            this.CmbNaziv.Size = new System.Drawing.Size(223, 28);
            this.CmbNaziv.TabIndex = 3;
            // 
            // LblKolicina
            // 
            this.LblKolicina.AutoSize = true;
            this.LblKolicina.Location = new System.Drawing.Point(20, 150);
            this.LblKolicina.Name = "LblKolicina";
            this.LblKolicina.Size = new System.Drawing.Size(65, 20);
            this.LblKolicina.TabIndex = 4;
            this.LblKolicina.Text = "Količina:";
            // 
            // TxtKolicina
            // 
            this.TxtKolicina.Location = new System.Drawing.Point(138, 147);
            this.TxtKolicina.Name = "TxtKolicina";
            this.TxtKolicina.Size = new System.Drawing.Size(223, 27);
            this.TxtKolicina.TabIndex = 5;
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.Location = new System.Drawing.Point(138, 200);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(103, 51);
            this.BtnSpremi.TabIndex = 6;
            this.BtnSpremi.Text = "Spremi stavku";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(258, 200);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(103, 51);
            this.BtnOdustani.TabIndex = 7;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // UnosStavkeSkladistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::HONING_App.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 295);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.TxtKolicina);
            this.Controls.Add(this.LblKolicina);
            this.Controls.Add(this.CmbNaziv);
            this.Controls.Add(this.LblNaziv);
            this.Controls.Add(this.GbxVrstaStavke);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UnosStavkeSkladistaForm";
            this.Text = "Unos stavke skladišta";
            this.GbxVrstaStavke.ResumeLayout(false);
            this.GbxVrstaStavke.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbxVrstaStavke;
        private System.Windows.Forms.RadioButton RbMaterijal;
        private System.Windows.Forms.RadioButton RbProizvod;
        private System.Windows.Forms.Label LblNaziv;
        private System.Windows.Forms.ComboBox CmbNaziv;
        private System.Windows.Forms.Label LblKolicina;
        private System.Windows.Forms.TextBox TxtKolicina;
        private System.Windows.Forms.Button BtnSpremi;
        private System.Windows.Forms.Button BtnOdustani;
    }
}