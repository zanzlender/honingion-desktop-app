
namespace HONING_App.Forme.Dodavanje_poduzeca
{
    partial class BazaPoduzecaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BazaPoduzecaForm));
            this.BtnObrisi = new System.Windows.Forms.Button();
            this.BtnIzmijeni = new System.Windows.Forms.Button();
            this.LblNaslov = new System.Windows.Forms.Label();
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.LblIspisCekanja = new MetroFramework.Controls.MetroLabel();
            this.DgvPoduzeca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPoduzeca)).BeginInit();
            this.SuspendLayout();
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
            this.BtnObrisi.Location = new System.Drawing.Point(343, 460);
            this.BtnObrisi.Name = "BtnObrisi";
            this.BtnObrisi.Size = new System.Drawing.Size(152, 33);
            this.BtnObrisi.TabIndex = 14;
            this.BtnObrisi.Text = "OBRIŠI PODUZEĆE";
            this.BtnObrisi.UseVisualStyleBackColor = false;
            this.BtnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // BtnIzmijeni
            // 
            this.BtnIzmijeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIzmijeni.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnIzmijeni.Enabled = false;
            this.BtnIzmijeni.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnIzmijeni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnIzmijeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzmijeni.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnIzmijeni.ForeColor = System.Drawing.Color.Black;
            this.BtnIzmijeni.Location = new System.Drawing.Point(521, 460);
            this.BtnIzmijeni.Name = "BtnIzmijeni";
            this.BtnIzmijeni.Size = new System.Drawing.Size(152, 33);
            this.BtnIzmijeni.TabIndex = 13;
            this.BtnIzmijeni.Text = "IZMIJENI PODUZEĆE";
            this.BtnIzmijeni.UseVisualStyleBackColor = false;
            this.BtnIzmijeni.Click += new System.EventHandler(this.BtnIzmijeni_Click);
            // 
            // LblNaslov
            // 
            this.LblNaslov.AutoSize = true;
            this.LblNaslov.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblNaslov.Location = new System.Drawing.Point(14, 22);
            this.LblNaslov.Name = "LblNaslov";
            this.LblNaslov.Size = new System.Drawing.Size(180, 30);
            this.LblNaslov.TabIndex = 12;
            this.LblNaslov.Text = "BAZA PODUZEĆA";
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDodaj.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(199)))), ((int)(((byte)(33)))));
            this.BtnDodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(245)))), ((int)(((byte)(128)))));
            this.BtnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDodaj.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDodaj.ForeColor = System.Drawing.Color.Black;
            this.BtnDodaj.Location = new System.Drawing.Point(701, 460);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(152, 33);
            this.BtnDodaj.TabIndex = 11;
            this.BtnDodaj.Text = "DODAJ PODUZEĆE";
            this.BtnDodaj.UseVisualStyleBackColor = false;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // LblIspisCekanja
            // 
            this.LblIspisCekanja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblIspisCekanja.AutoSize = true;
            this.LblIspisCekanja.BackColor = System.Drawing.SystemColors.Control;
            this.LblIspisCekanja.Location = new System.Drawing.Point(363, 251);
            this.LblIspisCekanja.Name = "LblIspisCekanja";
            this.LblIspisCekanja.Size = new System.Drawing.Size(144, 19);
            this.LblIspisCekanja.TabIndex = 10;
            this.LblIspisCekanja.Text = "Dohvaćanje podataka...";
            // 
            // DgvPoduzeca
            // 
            this.DgvPoduzeca.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPoduzeca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPoduzeca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPoduzeca.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvPoduzeca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPoduzeca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPoduzeca.ColumnHeadersHeight = 35;
            this.DgvPoduzeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvPoduzeca.GridColor = System.Drawing.Color.LightGray;
            this.DgvPoduzeca.Location = new System.Drawing.Point(19, 73);
            this.DgvPoduzeca.MultiSelect = false;
            this.DgvPoduzeca.Name = "DgvPoduzeca";
            this.DgvPoduzeca.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPoduzeca.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPoduzeca.RowHeadersVisible = false;
            this.DgvPoduzeca.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPoduzeca.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvPoduzeca.RowTemplate.Height = 25;
            this.DgvPoduzeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPoduzeca.Size = new System.Drawing.Size(834, 360);
            this.DgvPoduzeca.TabIndex = 9;
            this.DgvPoduzeca.SelectionChanged += new System.EventHandler(this.DgvPoduzeca_SelectionChanged);
            // 
            // BazaPoduzecaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HONING_App.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 520);
            this.Controls.Add(this.BtnObrisi);
            this.Controls.Add(this.BtnIzmijeni);
            this.Controls.Add(this.LblNaslov);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.LblIspisCekanja);
            this.Controls.Add(this.DgvPoduzeca);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BazaPoduzecaForm";
            this.Text = "BazaPoduzecaForm";
            this.Load += new System.EventHandler(this.BazaPoduzecaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPoduzeca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnObrisi;
        private System.Windows.Forms.Button BtnIzmijeni;
        private System.Windows.Forms.Label LblNaslov;
        private System.Windows.Forms.Button BtnDodaj;
        private MetroFramework.Controls.MetroLabel LblIspisCekanja;
        private System.Windows.Forms.DataGridView DgvPoduzeca;
    }
}