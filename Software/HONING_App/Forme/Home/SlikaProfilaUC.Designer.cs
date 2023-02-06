
namespace HONING_App.Forme.Home
{
    partial class SlikaProfilaUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlikaProfilaUC));
            this.PictureBoxProfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxProfil
            // 
            this.PictureBoxProfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxProfil.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxProfil.Image")));
            this.PictureBoxProfil.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxProfil.Name = "PictureBoxProfil";
            this.PictureBoxProfil.Size = new System.Drawing.Size(150, 150);
            this.PictureBoxProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxProfil.TabIndex = 0;
            this.PictureBoxProfil.TabStop = false;
            this.PictureBoxProfil.Click += new System.EventHandler(this.PictureBoxProfil_Click);
            // 
            // SlikaProfilaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PictureBoxProfil);
            this.Name = "SlikaProfilaUC";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxProfil;
    }
}
