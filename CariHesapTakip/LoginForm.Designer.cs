namespace CariHesapTakip
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
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(24, 73);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(97, 20);
            this.lblKullanıcıAdı.TabIndex = 0;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı:";
            // 
            // btnGiriş
            // 
            this.btnGiriş.Location = new System.Drawing.Point(284, 156);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(79, 29);
            this.btnGiriş.TabIndex = 1;
            this.btnGiriş.Text = "Giriş:";
            this.btnGiriş.UseVisualStyleBackColor = true;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(369, 156);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(79, 29);
            this.btnİptal.TabIndex = 2;
            this.btnİptal.Text = "İptal:";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(24, 130);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(58, 20);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola:";
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(127, 70);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(199, 26);
            this.txtKullanıcıAdı.TabIndex = 4;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(127, 124);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(199, 26);
            this.txtParola.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblBaslık);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 50);
            this.panel1.TabIndex = 6;
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.ForeColor = System.Drawing.Color.White;
            this.lblBaslık.Location = new System.Drawing.Point(110, 5);
            this.lblBaslık.Margin = new System.Windows.Forms.Padding(5);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(232, 32);
            this.lblBaslık.TabIndex = 0;
            this.lblBaslık.Text = "Cari Hesap Takip";
            this.lblBaslık.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(448, 194);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGiriş);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaslık;
    }
}