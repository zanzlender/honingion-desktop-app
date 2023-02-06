namespace HONING_App.Forme.Skladiste
{
    partial class IzmjenaMaterijalaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmjenaMaterijalaForm));
            this.BtnOdustani = new System.Windows.Forms.Button();
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.TxtSpecifikacija = new System.Windows.Forms.TextBox();
            this.LblSpecifikacije = new System.Windows.Forms.Label();
            this.LblNaziv = new System.Windows.Forms.Label();
            this.TxtNaziv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOdustani
            // 
            this.BtnOdustani.Location = new System.Drawing.Point(392, 135);
            this.BtnOdustani.Name = "BtnOdustani";
            this.BtnOdustani.Size = new System.Drawing.Size(117, 47);
            this.BtnOdustani.TabIndex = 21;
            this.BtnOdustani.Text = "Odustani";
            this.BtnOdustani.UseVisualStyleBackColor = true;
            this.BtnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.Location = new System.Drawing.Point(256, 135);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(117, 47);
            this.BtnSpremi.TabIndex = 20;
            this.BtnSpremi.Text = "Spremi izmjene";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // TxtSpecifikacija
            // 
            this.TxtSpecifikacija.Location = new System.Drawing.Point(256, 65);
            this.TxtSpecifikacija.Multiline = true;
            this.TxtSpecifikacija.Name = "TxtSpecifikacija";
            this.TxtSpecifikacija.Size = new System.Drawing.Size(250, 64);
            this.TxtSpecifikacija.TabIndex = 19;
            // 
            // LblSpecifikacije
            // 
            this.LblSpecifikacije.AutoSize = true;
            this.LblSpecifikacije.Location = new System.Drawing.Point(32, 65);
            this.LblSpecifikacije.Name = "LblSpecifikacije";
            this.LblSpecifikacije.Size = new System.Drawing.Size(90, 17);
            this.LblSpecifikacije.TabIndex = 18;
            this.LblSpecifikacije.Text = "Specifikacije:";
            // 
            // LblNaziv
            // 
            this.LblNaziv.AutoSize = true;
            this.LblNaziv.Location = new System.Drawing.Point(32, 30);
            this.LblNaziv.Name = "LblNaziv";
            this.LblNaziv.Size = new System.Drawing.Size(178, 17);
            this.LblNaziv.TabIndex = 15;
            this.LblNaziv.Text = "Naziv materijala ili sirovine:";
            // 
            // TxtNaziv
            // 
            this.TxtNaziv.Location = new System.Drawing.Point(256, 27);
            this.TxtNaziv.Name = "TxtNaziv";
            this.TxtNaziv.Size = new System.Drawing.Size(253, 22);
            this.TxtNaziv.TabIndex = 14;
            // 
            // IzmjenaMaterijalaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::HONING_App.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 212);
            this.Controls.Add(this.BtnOdustani);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.TxtSpecifikacija);
            this.Controls.Add(this.LblSpecifikacije);
            this.Controls.Add(this.LblNaziv);
            this.Controls.Add(this.TxtNaziv);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzmjenaMaterijalaForm";
            this.Text = "Izmjena zapisa materijala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOdustani;
        private System.Windows.Forms.Button BtnSpremi;
        private System.Windows.Forms.TextBox TxtSpecifikacija;
        private System.Windows.Forms.Label LblSpecifikacije;
        private System.Windows.Forms.Label LblNaziv;
        private System.Windows.Forms.TextBox TxtNaziv;
    }
}