
namespace HONING_App.Forme.Baza_zaposlenika
{
    partial class BazaZaposlenikaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.LblIspisCekanja = new MetroFramework.Controls.MetroLabel();
            this.BtnDodajZaposlenika = new System.Windows.Forms.Button();
            this.LblNaslov = new System.Windows.Forms.Label();
            this.BtnIzmijeniZaposlenika = new System.Windows.Forms.Button();
            this.BtnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvZaposlenici
            // 
            this.DgvZaposlenici.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvZaposlenici.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvZaposlenici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvZaposlenici.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvZaposlenici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvZaposlenici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvZaposlenici.ColumnHeadersHeight = 35;
            this.DgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvZaposlenici.GridColor = System.Drawing.Color.LightGray;
            this.DgvZaposlenici.Location = new System.Drawing.Point(12, 66);
            this.DgvZaposlenici.MultiSelect = false;
            this.DgvZaposlenici.Name = "DgvZaposlenici";
            this.DgvZaposlenici.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvZaposlenici.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvZaposlenici.RowHeadersVisible = false;
            this.DgvZaposlenici.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvZaposlenici.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvZaposlenici.RowTemplate.Height = 25;
            this.DgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvZaposlenici.Size = new System.Drawing.Size(842, 378);
            this.DgvZaposlenici.TabIndex = 0;
            this.DgvZaposlenici.SelectionChanged += new System.EventHandler(this.DgvZaposlenici_SelectionChanged);
            // 
            // LblIspisCekanja
            // 
            this.LblIspisCekanja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblIspisCekanja.AutoSize = true;
            this.LblIspisCekanja.Location = new System.Drawing.Point(356, 247);
            this.LblIspisCekanja.Name = "LblIspisCekanja";
            this.LblIspisCekanja.Size = new System.Drawing.Size(144, 19);
            this.LblIspisCekanja.TabIndex = 2;
            this.LblIspisCekanja.Text = "Dohvaćanje podataka...";
            // 
            // BtnDodajZaposlenika
            // 
            this.BtnDodajZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDodajZaposlenika.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnDodajZaposlenika.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDodajZaposlenika.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(199)))), ((int)(((byte)(33)))));
            this.BtnDodajZaposlenika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(245)))), ((int)(((byte)(128)))));
            this.BtnDodajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDodajZaposlenika.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodajZaposlenika.ForeColor = System.Drawing.Color.Black;
            this.BtnDodajZaposlenika.Location = new System.Drawing.Point(694, 486);
            this.BtnDodajZaposlenika.Name = "BtnDodajZaposlenika";
            this.BtnDodajZaposlenika.Size = new System.Drawing.Size(152, 33);
            this.BtnDodajZaposlenika.TabIndex = 5;
            this.BtnDodajZaposlenika.Text = "DODAJ ZAPOSLENIKA";
            this.BtnDodajZaposlenika.UseVisualStyleBackColor = false;
            this.BtnDodajZaposlenika.Click += new System.EventHandler(this.BtnDodajZaposlenika_Click);
            // 
            // LblNaslov
            // 
            this.LblNaslov.AutoSize = true;
            this.LblNaslov.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblNaslov.Location = new System.Drawing.Point(7, 19);
            this.LblNaslov.Name = "LblNaslov";
            this.LblNaslov.Size = new System.Drawing.Size(207, 30);
            this.LblNaslov.TabIndex = 6;
            this.LblNaslov.Text = "BAZA ZAPOSLENIKA";
            // 
            // BtnIzmijeniZaposlenika
            // 
            this.BtnIzmijeniZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIzmijeniZaposlenika.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnIzmijeniZaposlenika.Enabled = false;
            this.BtnIzmijeniZaposlenika.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnIzmijeniZaposlenika.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnIzmijeniZaposlenika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnIzmijeniZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzmijeniZaposlenika.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIzmijeniZaposlenika.ForeColor = System.Drawing.Color.Black;
            this.BtnIzmijeniZaposlenika.Location = new System.Drawing.Point(514, 486);
            this.BtnIzmijeniZaposlenika.Name = "BtnIzmijeniZaposlenika";
            this.BtnIzmijeniZaposlenika.Size = new System.Drawing.Size(152, 33);
            this.BtnIzmijeniZaposlenika.TabIndex = 7;
            this.BtnIzmijeniZaposlenika.Text = "IZMIJENI ZAPOSLENIKA";
            this.BtnIzmijeniZaposlenika.UseVisualStyleBackColor = false;
            this.BtnIzmijeniZaposlenika.Click += new System.EventHandler(this.BtnIzmijeniZaposlenika_Click);
            // 
            // BtnObrisi
            // 
            this.BtnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnObrisi.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnObrisi.Enabled = false;
            this.BtnObrisi.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnObrisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnObrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnObrisi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnObrisi.ForeColor = System.Drawing.Color.Black;
            this.BtnObrisi.Location = new System.Drawing.Point(336, 486);
            this.BtnObrisi.Name = "BtnObrisi";
            this.BtnObrisi.Size = new System.Drawing.Size(152, 33);
            this.BtnObrisi.TabIndex = 8;
            this.BtnObrisi.Text = "OBRIŠI ZAPOSLENIKA";
            this.BtnObrisi.UseVisualStyleBackColor = false;
            this.BtnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // BazaZaposlenikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HONING_App.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 545);
            this.Controls.Add(this.LblIspisCekanja);
            this.Controls.Add(this.DgvZaposlenici);
            this.Controls.Add(this.BtnObrisi);
            this.Controls.Add(this.BtnIzmijeniZaposlenika);
            this.Controls.Add(this.LblNaslov);
            this.Controls.Add(this.BtnDodajZaposlenika);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BazaZaposlenikaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BazaZaposlenikaForm";
            this.Load += new System.EventHandler(this.BazaZaposlenikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvZaposlenici;
        private MetroFramework.Controls.MetroLabel LblIspisCekanja;
        private System.Windows.Forms.Button BtnDodajZaposlenika;
        private System.Windows.Forms.Label LblNaslov;
        private System.Windows.Forms.Button BtnIzmijeniZaposlenika;
        private System.Windows.Forms.Button BtnObrisi;
    }
}