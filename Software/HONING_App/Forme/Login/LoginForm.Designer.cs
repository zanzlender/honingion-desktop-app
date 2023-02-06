
namespace HONING_App
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIntro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IconIzlaz = new FontAwesome.Sharp.IconPictureBox();
            this.ProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.CheckBoxPrikaziLozinku = new System.Windows.Forms.CheckBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtLozinka = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblPrijavaForm = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.BtnPrijava = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelLozinka = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.lblIntro);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 427);
            this.panel1.TabIndex = 0;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.CausesValidation = false;
            this.lblIntro.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIntro.ForeColor = System.Drawing.Color.White;
            this.lblIntro.Location = new System.Drawing.Point(51, 258);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(201, 21);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Dizajn, inovacije, budućnost";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.IconIzlaz);
            this.panel2.Controls.Add(this.ProgressBar);
            this.panel2.Controls.Add(this.CheckBoxPrikaziLozinku);
            this.panel2.Controls.Add(this.TxtEmail);
            this.panel2.Controls.Add(this.TxtLozinka);
            this.panel2.Controls.Add(this.lblLozinka);
            this.panel2.Controls.Add(this.lblPrijavaForm);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.BtnPrijava);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelLozinka);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(303, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 427);
            this.panel2.TabIndex = 1;
            // 
            // IconIzlaz
            // 
            this.IconIzlaz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IconIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconIzlaz.ForeColor = System.Drawing.Color.DarkGray;
            this.IconIzlaz.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.IconIzlaz.IconColor = System.Drawing.Color.DarkGray;
            this.IconIzlaz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconIzlaz.IconSize = 28;
            this.IconIzlaz.Location = new System.Drawing.Point(263, 15);
            this.IconIzlaz.Name = "IconIzlaz";
            this.IconIzlaz.Size = new System.Drawing.Size(28, 28);
            this.IconIzlaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconIzlaz.TabIndex = 18;
            this.IconIzlaz.TabStop = false;
            this.IconIzlaz.Click += new System.EventHandler(this.IconIzlaz_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(31, 347);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressBar.MarqueeAnimationSpeed = 500;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.Size = new System.Drawing.Size(236, 35);
            this.ProgressBar.Style = MetroFramework.MetroColorStyle.Silver;
            this.ProgressBar.TabIndex = 16;
            this.ProgressBar.Visible = false;
            // 
            // CheckBoxPrikaziLozinku
            // 
            this.CheckBoxPrikaziLozinku.AutoSize = true;
            this.CheckBoxPrikaziLozinku.CausesValidation = false;
            this.CheckBoxPrikaziLozinku.FlatAppearance.BorderSize = 0;
            this.CheckBoxPrikaziLozinku.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckBoxPrikaziLozinku.ForeColor = System.Drawing.Color.DimGray;
            this.CheckBoxPrikaziLozinku.Location = new System.Drawing.Point(97, 301);
            this.CheckBoxPrikaziLozinku.Name = "CheckBoxPrikaziLozinku";
            this.CheckBoxPrikaziLozinku.Size = new System.Drawing.Size(101, 19);
            this.CheckBoxPrikaziLozinku.TabIndex = 11;
            this.CheckBoxPrikaziLozinku.Text = "Prikaži lozinku";
            this.CheckBoxPrikaziLozinku.UseVisualStyleBackColor = true;
            this.CheckBoxPrikaziLozinku.CheckedChanged += new System.EventHandler(this.CheckBoxPrikaziLozinku_CheckedChanged);
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconAlignment(this.TxtEmail, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.TxtEmail.Location = new System.Drawing.Point(37, 151);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(230, 18);
            this.TxtEmail.TabIndex = 0;
            this.TxtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            this.TxtEmail.Validated += new System.EventHandler(this.TxtEmail_Validated);
            // 
            // TxtLozinka
            // 
            this.TxtLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLozinka.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errorProvider1.SetIconAlignment(this.TxtLozinka, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.TxtLozinka.Location = new System.Drawing.Point(37, 238);
            this.TxtLozinka.Name = "TxtLozinka";
            this.TxtLozinka.PasswordChar = '*';
            this.TxtLozinka.Size = new System.Drawing.Size(230, 18);
            this.TxtLozinka.TabIndex = 1;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.CausesValidation = false;
            this.lblLozinka.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.lblLozinka.Location = new System.Drawing.Point(28, 204);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(50, 17);
            this.lblLozinka.TabIndex = 9;
            this.lblLozinka.Text = "Lozinka";
            // 
            // lblPrijavaForm
            // 
            this.lblPrijavaForm.AutoSize = true;
            this.lblPrijavaForm.CausesValidation = false;
            this.lblPrijavaForm.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrijavaForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.lblPrijavaForm.Location = new System.Drawing.Point(105, 46);
            this.lblPrijavaForm.Name = "lblPrijavaForm";
            this.lblPrijavaForm.Size = new System.Drawing.Size(76, 30);
            this.lblPrijavaForm.TabIndex = 5;
            this.lblPrijavaForm.Text = "Prijava";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.CausesValidation = false;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.lblEmail.Location = new System.Drawing.Point(28, 119);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail";
            // 
            // BtnPrijava
            // 
            this.BtnPrijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.BtnPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrijava.Enabled = false;
            this.BtnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrijava.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPrijava.ForeColor = System.Drawing.Color.White;
            this.BtnPrijava.Location = new System.Drawing.Point(31, 347);
            this.BtnPrijava.Name = "BtnPrijava";
            this.BtnPrijava.Size = new System.Drawing.Size(236, 35);
            this.BtnPrijava.TabIndex = 3;
            this.BtnPrijava.Text = "PRIJAVA";
            this.BtnPrijava.UseVisualStyleBackColor = false;
            this.BtnPrijava.Click += new System.EventHandler(this.BtnPrijava_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.CausesValidation = false;
            this.panel3.Location = new System.Drawing.Point(31, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 35);
            this.panel3.TabIndex = 12;
            // 
            // panelLozinka
            // 
            this.panelLozinka.BackColor = System.Drawing.Color.White;
            this.panelLozinka.CausesValidation = false;
            this.panelLozinka.Location = new System.Drawing.Point(31, 229);
            this.panelLozinka.Name = "panelLozinka";
            this.panelLozinka.Size = new System.Drawing.Size(236, 35);
            this.panelLozinka.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(606, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblPrijavaForm;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button BtnPrijava;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtLozinka;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.CheckBox CheckBoxPrikaziLozinku;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelLozinka;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroProgressBar ProgressBar;
        private FontAwesome.Sharp.IconPictureBox IconIzlaz;
    }
}

