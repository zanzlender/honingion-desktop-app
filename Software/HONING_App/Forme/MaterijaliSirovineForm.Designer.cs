namespace HONING_App.Forme
{
    partial class MaterijaliSirovineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterijaliSirovineForm));
            this.LblNaslov = new System.Windows.Forms.Label();
            this.DgvMaterijali = new System.Windows.Forms.DataGridView();
            this.BtnUnos = new System.Windows.Forms.Button();
            this.BtnUredi = new System.Windows.Forms.Button();
            this.BtnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterijali)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNaslov
            // 
            this.LblNaslov.AutoSize = true;
            this.LblNaslov.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblNaslov.Location = new System.Drawing.Point(28, 34);
            this.LblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNaslov.Name = "LblNaslov";
            this.LblNaslov.Size = new System.Drawing.Size(303, 37);
            this.LblNaslov.TabIndex = 15;
            this.LblNaslov.Text = "MATERIJALI I SIROVINE";
            // 
            // DgvMaterijali
            // 
            this.DgvMaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMaterijali.Location = new System.Drawing.Point(35, 98);
            this.DgvMaterijali.Name = "DgvMaterijali";
            this.DgvMaterijali.RowHeadersWidth = 51;
            this.DgvMaterijali.RowTemplate.Height = 24;
            this.DgvMaterijali.Size = new System.Drawing.Size(554, 235);
            this.DgvMaterijali.TabIndex = 16;
            // 
            // BtnUnos
            // 
            this.BtnUnos.Location = new System.Drawing.Point(35, 350);
            this.BtnUnos.Name = "BtnUnos";
            this.BtnUnos.Size = new System.Drawing.Size(191, 35);
            this.BtnUnos.TabIndex = 17;
            this.BtnUnos.Text = "Novi unos";
            this.BtnUnos.UseVisualStyleBackColor = true;
            this.BtnUnos.Click += new System.EventHandler(this.BtnUnos_Click);
            // 
            // BtnUredi
            // 
            this.BtnUredi.Location = new System.Drawing.Point(35, 432);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(191, 35);
            this.BtnUredi.TabIndex = 18;
            this.BtnUredi.Text = "Uredi";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // BtnObrisi
            // 
            this.BtnObrisi.Location = new System.Drawing.Point(35, 391);
            this.BtnObrisi.Name = "BtnObrisi";
            this.BtnObrisi.Size = new System.Drawing.Size(191, 35);
            this.BtnObrisi.TabIndex = 19;
            this.BtnObrisi.Text = "Obriši";
            this.BtnObrisi.UseVisualStyleBackColor = true;
            this.BtnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // MaterijaliSirovineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::HONING_App.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 617);
            this.Controls.Add(this.BtnObrisi);
            this.Controls.Add(this.BtnUredi);
            this.Controls.Add(this.BtnUnos);
            this.Controls.Add(this.DgvMaterijali);
            this.Controls.Add(this.LblNaslov);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MaterijaliSirovineForm";
            this.Text = "MaterijaliSirovineForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMaterijali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNaslov;
        private System.Windows.Forms.DataGridView DgvMaterijali;
        private System.Windows.Forms.Button BtnUnos;
        private System.Windows.Forms.Button BtnUredi;
        private System.Windows.Forms.Button BtnObrisi;
    }
}