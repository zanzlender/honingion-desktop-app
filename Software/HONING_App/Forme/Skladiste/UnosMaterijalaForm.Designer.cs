namespace HONING_App.Forme.Skladiste
{
    partial class UnosMaterijalaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosMaterijalaForm));
            this.TxtNaziv = new System.Windows.Forms.TextBox();
            this.LblNaziv = new System.Windows.Forms.Label();
            this.LblPartner = new System.Windows.Forms.Label();
            this.CmbPartner = new System.Windows.Forms.ComboBox();
            this.LblSpecifikacije = new System.Windows.Forms.Label();
            this.TxtSpecifikacija = new System.Windows.Forms.TextBox();
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.LblJedinica = new System.Windows.Forms.Label();
            this.CmbJedinica = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TxtNaziv
            // 
            this.TxtNaziv.Location = new System.Drawing.Point(262, 56);
            this.TxtNaziv.Name = "TxtNaziv";
            this.TxtNaziv.Size = new System.Drawing.Size(253, 22);
            this.TxtNaziv.TabIndex = 0;
            // 
            // LblNaziv
            // 
            this.LblNaziv.AutoSize = true;
            this.LblNaziv.Location = new System.Drawing.Point(38, 59);
            this.LblNaziv.Name = "LblNaziv";
            this.LblNaziv.Size = new System.Drawing.Size(178, 17);
            this.LblNaziv.TabIndex = 1;
            this.LblNaziv.Text = "Naziv materijala ili sirovine:";
            // 
            // LblPartner
            // 
            this.LblPartner.AutoSize = true;
            this.LblPartner.Location = new System.Drawing.Point(38, 131);
            this.LblPartner.Name = "LblPartner";
            this.LblPartner.Size = new System.Drawing.Size(115, 17);
            this.LblPartner.TabIndex = 6;
            this.LblPartner.Text = "Poslovni partner:";
            // 
            // CmbPartner
            // 
            this.CmbPartner.FormattingEnabled = true;
            this.CmbPartner.Location = new System.Drawing.Point(262, 128);
            this.CmbPartner.Name = "CmbPartner";
            this.CmbPartner.Size = new System.Drawing.Size(250, 24);
            this.CmbPartner.TabIndex = 7;
            // 
            // LblSpecifikacije
            // 
            this.LblSpecifikacije.AutoSize = true;
            this.LblSpecifikacije.Location = new System.Drawing.Point(38, 168);
            this.LblSpecifikacije.Name = "LblSpecifikacije";
            this.LblSpecifikacije.Size = new System.Drawing.Size(90, 17);
            this.LblSpecifikacije.TabIndex = 8;
            this.LblSpecifikacije.Text = "Specifikacije:";
            // 
            // TxtSpecifikacija
            // 
            this.TxtSpecifikacija.Location = new System.Drawing.Point(262, 165);
            this.TxtSpecifikacija.Multiline = true;
            this.TxtSpecifikacija.Name = "TxtSpecifikacija";
            this.TxtSpecifikacija.Size = new System.Drawing.Size(250, 64);
            this.TxtSpecifikacija.TabIndex = 9;
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.Location = new System.Drawing.Point(262, 275);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(117, 47);
            this.BtnSpremi.TabIndex = 10;
            this.BtnSpremi.Text = "Spremi unos";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(395, 275);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(117, 47);
            this.BtnOdustani.TabIndex = 11;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            // 
            // LblJedinica
            // 
            this.LblJedinica.AutoSize = true;
            this.LblJedinica.Location = new System.Drawing.Point(38, 97);
            this.LblJedinica.Name = "LblJedinica";
            this.LblJedinica.Size = new System.Drawing.Size(107, 17);
            this.LblJedinica.TabIndex = 12;
            this.LblJedinica.Text = "Mjerna jedinica:";
            // 
            // CmbJedinica
            // 
            this.CmbJedinica.FormattingEnabled = true;
            this.CmbJedinica.Location = new System.Drawing.Point(262, 90);
            this.CmbJedinica.Name = "CmbJedinica";
            this.CmbJedinica.Size = new System.Drawing.Size(250, 24);
            this.CmbJedinica.TabIndex = 13;
            // 
            // UnosMaterijalaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::HONING_App.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 364);
            this.Controls.Add(this.CmbJedinica);
            this.Controls.Add(this.LblJedinica);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.TxtSpecifikacija);
            this.Controls.Add(this.LblSpecifikacije);
            this.Controls.Add(this.CmbPartner);
            this.Controls.Add(this.LblPartner);
            this.Controls.Add(this.LblNaziv);
            this.Controls.Add(this.TxtNaziv);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnosMaterijalaForm";
            this.Text = "Unos materijala i sirovina";
            this.Load += new System.EventHandler(this.UnosMaterijalaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNaziv;
        private System.Windows.Forms.Label LblNaziv;
        private System.Windows.Forms.Label LblPartner;
        private System.Windows.Forms.ComboBox CmbPartner;
        private System.Windows.Forms.Label LblSpecifikacije;
        private System.Windows.Forms.TextBox TxtSpecifikacija;
        private System.Windows.Forms.Button BtnSpremi;
        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Label LblJedinica;
        private System.Windows.Forms.ComboBox CmbJedinica;
    }
}