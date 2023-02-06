namespace HONING_App.Forme.Skladiste
{
    partial class SkladisteForm
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
            this.DgvStavkeSkladista = new System.Windows.Forms.DataGridView();
            this.LblNaslov = new System.Windows.Forms.Label();
            this.BtnOtvoriMaterijale = new System.Windows.Forms.Button();
            this.BtnUnosStavke = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbSve = new System.Windows.Forms.RadioButton();
            this.RbProizvodi = new System.Windows.Forms.RadioButton();
            this.RbMaterijali = new System.Windows.Forms.RadioButton();
            this.BtnIzdano = new System.Windows.Forms.Button();
            this.LblStavkeSkladista = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStavkeSkladista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvStavkeSkladista
            // 
            this.DgvStavkeSkladista.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvStavkeSkladista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvStavkeSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStavkeSkladista.Location = new System.Drawing.Point(12, 126);
            this.DgvStavkeSkladista.Name = "DgvStavkeSkladista";
            this.DgvStavkeSkladista.RowHeadersWidth = 51;
            this.DgvStavkeSkladista.RowTemplate.Height = 24;
            this.DgvStavkeSkladista.Size = new System.Drawing.Size(743, 198);
            this.DgvStavkeSkladista.TabIndex = 0;
            // 
            // LblNaslov
            // 
            this.LblNaslov.AutoSize = true;
            this.LblNaslov.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblNaslov.Location = new System.Drawing.Point(23, 28);
            this.LblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNaslov.Name = "LblNaslov";
            this.LblNaslov.Size = new System.Drawing.Size(152, 37);
            this.LblNaslov.TabIndex = 14;
            this.LblNaslov.Text = "SKLADIŠTE";
            // 
            // BtnOtvoriMaterijale
            // 
            this.BtnOtvoriMaterijale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnOtvoriMaterijale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOtvoriMaterijale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnOtvoriMaterijale.Location = new System.Drawing.Point(503, 345);
            this.BtnOtvoriMaterijale.Name = "BtnOtvoriMaterijale";
            this.BtnOtvoriMaterijale.Size = new System.Drawing.Size(252, 58);
            this.BtnOtvoriMaterijale.TabIndex = 18;
            this.BtnOtvoriMaterijale.Text = "MATERIJALI I SIROVINE";
            this.BtnOtvoriMaterijale.UseVisualStyleBackColor = false;
            this.BtnOtvoriMaterijale.Click += new System.EventHandler(this.BtnOtvoriMaterijale_Click);
            // 
            // BtnUnosStavke
            // 
            this.BtnUnosStavke.Location = new System.Drawing.Point(237, 345);
            this.BtnUnosStavke.Name = "BtnUnosStavke";
            this.BtnUnosStavke.Size = new System.Drawing.Size(141, 58);
            this.BtnUnosStavke.TabIndex = 19;
            this.BtnUnosStavke.Text = "Unesi stavku skladišta";
            this.BtnUnosStavke.UseVisualStyleBackColor = true;
            this.BtnUnosStavke.Click += new System.EventHandler(this.BtnUnosStavke_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.RbSve);
            this.groupBox1.Controls.Add(this.RbProizvodi);
            this.groupBox1.Controls.Add(this.RbMaterijali);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 126);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sortiraj stavke skladišta";
            // 
            // RbSve
            // 
            this.RbSve.AutoSize = true;
            this.RbSve.Location = new System.Drawing.Point(27, 87);
            this.RbSve.Name = "RbSve";
            this.RbSve.Size = new System.Drawing.Size(58, 27);
            this.RbSve.TabIndex = 2;
            this.RbSve.TabStop = true;
            this.RbSve.Text = "Sve";
            this.RbSve.UseVisualStyleBackColor = true;
            this.RbSve.CheckedChanged += new System.EventHandler(this.RbSve_CheckedChanged);
            // 
            // RbProizvodi
            // 
            this.RbProizvodi.AutoSize = true;
            this.RbProizvodi.Location = new System.Drawing.Point(27, 57);
            this.RbProizvodi.Name = "RbProizvodi";
            this.RbProizvodi.Size = new System.Drawing.Size(102, 27);
            this.RbProizvodi.TabIndex = 1;
            this.RbProizvodi.TabStop = true;
            this.RbProizvodi.Text = "Proizvodi";
            this.RbProizvodi.UseVisualStyleBackColor = true;
            this.RbProizvodi.CheckedChanged += new System.EventHandler(this.RbProizvodi_CheckedChanged);
            // 
            // RbMaterijali
            // 
            this.RbMaterijali.AutoSize = true;
            this.RbMaterijali.Location = new System.Drawing.Point(27, 29);
            this.RbMaterijali.Name = "RbMaterijali";
            this.RbMaterijali.Size = new System.Drawing.Size(175, 27);
            this.RbMaterijali.TabIndex = 0;
            this.RbMaterijali.TabStop = true;
            this.RbMaterijali.Text = "Materijali i sirovine";
            this.RbMaterijali.UseVisualStyleBackColor = true;
            this.RbMaterijali.CheckedChanged += new System.EventHandler(this.RbMaterijali_CheckedChanged);
            // 
            // BtnIzdano
            // 
            this.BtnIzdano.Location = new System.Drawing.Point(237, 415);
            this.BtnIzdano.Name = "BtnIzdano";
            this.BtnIzdano.Size = new System.Drawing.Size(141, 56);
            this.BtnIzdano.TabIndex = 21;
            this.BtnIzdano.Text = "Otprema stavki iz skladišta";
            this.BtnIzdano.UseVisualStyleBackColor = true;
            this.BtnIzdano.Click += new System.EventHandler(this.BtnIzdano_Click);
            // 
            // LblStavkeSkladista
            // 
            this.LblStavkeSkladista.AutoSize = true;
            this.LblStavkeSkladista.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.LblStavkeSkladista.Location = new System.Drawing.Point(26, 98);
            this.LblStavkeSkladista.Name = "LblStavkeSkladista";
            this.LblStavkeSkladista.Size = new System.Drawing.Size(257, 25);
            this.LblStavkeSkladista.TabIndex = 22;
            this.LblStavkeSkladista.Text = "Stavke dostupne na skladištu:";
            // 
            // SkladisteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::HONING_App.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.LblStavkeSkladista);
            this.Controls.Add(this.BtnIzdano);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnUnosStavke);
            this.Controls.Add(this.BtnOtvoriMaterijale);
            this.Controls.Add(this.LblNaslov);
            this.Controls.Add(this.DgvStavkeSkladista);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SkladisteForm";
            this.Text = "SkladisteForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvStavkeSkladista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvStavkeSkladista;
        private System.Windows.Forms.Label LblNaslov;
        private System.Windows.Forms.Button BtnOtvoriMaterijale;
        private System.Windows.Forms.Button BtnUnosStavke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbSve;
        private System.Windows.Forms.RadioButton RbProizvodi;
        private System.Windows.Forms.RadioButton RbMaterijali;
        private System.Windows.Forms.Button BtnIzdano;
        private System.Windows.Forms.Label LblStavkeSkladista;
    }
}