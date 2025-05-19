namespace CariHesapTakip.UI.Controls
{
    partial class UC_Personel
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpPersonel = new System.Windows.Forms.TableLayoutPanel();
            this.lblPersAd = new System.Windows.Forms.Label();
            this.lblPersSoyad = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtPersAd = new System.Windows.Forms.TextBox();
            this.txtPersSoyad = new System.Windows.Forms.TextBox();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.txtEmailPers = new System.Windows.Forms.TextBox();
            this.txtTelefonPers = new System.Windows.Forms.TextBox();
            this.flpPersButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPersEkle = new System.Windows.Forms.Button();
            this.btnPersGuncelle = new System.Windows.Forms.Button();
            this.btnPersSil = new System.Windows.Forms.Button();
            this.dgvPersonel = new System.Windows.Forms.DataGridView();
            this.tlpPersonel.SuspendLayout();
            this.flpPersButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPersonel
            // 
            this.tlpPersonel.ColumnCount = 2;
            this.tlpPersonel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPersonel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpPersonel.Controls.Add(this.lblPersAd, 0, 0);
            this.tlpPersonel.Controls.Add(this.lblPersSoyad, 0, 1);
            this.tlpPersonel.Controls.Add(this.lblDepartman, 0, 2);
            this.tlpPersonel.Controls.Add(this.lblEmail, 0, 3);
            this.tlpPersonel.Controls.Add(this.lblTelefon, 0, 4);
            this.tlpPersonel.Controls.Add(this.txtPersAd, 1, 0);
            this.tlpPersonel.Controls.Add(this.txtPersSoyad, 1, 1);
            this.tlpPersonel.Controls.Add(this.txtDepartman, 1, 2);
            this.tlpPersonel.Controls.Add(this.txtEmailPers, 1, 3);
            this.tlpPersonel.Controls.Add(this.txtTelefonPers, 1, 4);
            this.tlpPersonel.Controls.Add(this.flpPersButtons, 0, 5);
            this.tlpPersonel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpPersonel.Location = new System.Drawing.Point(0, 0);
            this.tlpPersonel.Name = "tlpPersonel";
            this.tlpPersonel.RowCount = 6;
            this.tlpPersonel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPersonel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPersonel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPersonel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPersonel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPersonel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpPersonel.Size = new System.Drawing.Size(804, 180);
            this.tlpPersonel.TabIndex = 0;
            // 
            // lblPersAd
            // 
            this.lblPersAd.AutoSize = true;
            this.lblPersAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPersAd.Location = new System.Drawing.Point(5, 5);
            this.lblPersAd.Margin = new System.Windows.Forms.Padding(5);
            this.lblPersAd.Name = "lblPersAd";
            this.lblPersAd.Size = new System.Drawing.Size(231, 20);
            this.lblPersAd.TabIndex = 0;
            this.lblPersAd.Text = "Personel Ad:";
            this.lblPersAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPersSoyad
            // 
            this.lblPersSoyad.AutoSize = true;
            this.lblPersSoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPersSoyad.Location = new System.Drawing.Point(5, 35);
            this.lblPersSoyad.Margin = new System.Windows.Forms.Padding(5);
            this.lblPersSoyad.Name = "lblPersSoyad";
            this.lblPersSoyad.Size = new System.Drawing.Size(231, 20);
            this.lblPersSoyad.TabIndex = 1;
            this.lblPersSoyad.Text = "Personel Soyad:";
            this.lblPersSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepartman
            // 
            this.lblDepartman.AutoSize = true;
            this.lblDepartman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepartman.Location = new System.Drawing.Point(5, 65);
            this.lblDepartman.Margin = new System.Windows.Forms.Padding(5);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(231, 20);
            this.lblDepartman.TabIndex = 2;
            this.lblDepartman.Text = "Departman";
            this.lblDepartman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(5, 95);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(231, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTelefon.Location = new System.Drawing.Point(5, 125);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(5);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(231, 20);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon:";
            this.lblTelefon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPersAd
            // 
            this.txtPersAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPersAd.Location = new System.Drawing.Point(244, 3);
            this.txtPersAd.Name = "txtPersAd";
            this.txtPersAd.Size = new System.Drawing.Size(557, 26);
            this.txtPersAd.TabIndex = 5;
            // 
            // txtPersSoyad
            // 
            this.txtPersSoyad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPersSoyad.Location = new System.Drawing.Point(244, 33);
            this.txtPersSoyad.Name = "txtPersSoyad";
            this.txtPersSoyad.Size = new System.Drawing.Size(557, 26);
            this.txtPersSoyad.TabIndex = 6;
            // 
            // txtDepartman
            // 
            this.txtDepartman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDepartman.Location = new System.Drawing.Point(244, 63);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(557, 26);
            this.txtDepartman.TabIndex = 7;
            // 
            // txtEmailPers
            // 
            this.txtEmailPers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmailPers.Location = new System.Drawing.Point(244, 93);
            this.txtEmailPers.Name = "txtEmailPers";
            this.txtEmailPers.Size = new System.Drawing.Size(557, 26);
            this.txtEmailPers.TabIndex = 8;
            // 
            // txtTelefonPers
            // 
            this.txtTelefonPers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTelefonPers.Location = new System.Drawing.Point(244, 123);
            this.txtTelefonPers.Name = "txtTelefonPers";
            this.txtTelefonPers.Size = new System.Drawing.Size(557, 26);
            this.txtTelefonPers.TabIndex = 9;
            // 
            // flpPersButtons
            // 
            this.tlpPersonel.SetColumnSpan(this.flpPersButtons, 2);
            this.flpPersButtons.Controls.Add(this.btnPersEkle);
            this.flpPersButtons.Controls.Add(this.btnPersGuncelle);
            this.flpPersButtons.Controls.Add(this.btnPersSil);
            this.flpPersButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPersButtons.Location = new System.Drawing.Point(3, 153);
            this.flpPersButtons.Name = "flpPersButtons";
            this.flpPersButtons.Size = new System.Drawing.Size(798, 34);
            this.flpPersButtons.TabIndex = 10;
            this.flpPersButtons.WrapContents = false;
            // 
            // btnPersEkle
            // 
            this.btnPersEkle.Location = new System.Drawing.Point(5, 5);
            this.btnPersEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersEkle.Name = "btnPersEkle";
            this.btnPersEkle.Size = new System.Drawing.Size(112, 29);
            this.btnPersEkle.TabIndex = 0;
            this.btnPersEkle.Text = "Ekle";
            this.btnPersEkle.UseVisualStyleBackColor = true;
            // 
            // btnPersGuncelle
            // 
            this.btnPersGuncelle.Location = new System.Drawing.Point(127, 5);
            this.btnPersGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersGuncelle.Name = "btnPersGuncelle";
            this.btnPersGuncelle.Size = new System.Drawing.Size(124, 27);
            this.btnPersGuncelle.TabIndex = 1;
            this.btnPersGuncelle.Text = "Güncelle";
            this.btnPersGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnPersSil
            // 
            this.btnPersSil.Location = new System.Drawing.Point(261, 5);
            this.btnPersSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersSil.Name = "btnPersSil";
            this.btnPersSil.Size = new System.Drawing.Size(92, 29);
            this.btnPersSil.TabIndex = 2;
            this.btnPersSil.Text = "Sil";
            this.btnPersSil.UseVisualStyleBackColor = true;
            // 
            // dgvPersonel
            // 
            this.dgvPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonel.Location = new System.Drawing.Point(0, 180);
            this.dgvPersonel.Name = "dgvPersonel";
            this.dgvPersonel.ReadOnly = true;
            this.dgvPersonel.RowHeadersWidth = 62;
            this.dgvPersonel.RowTemplate.Height = 28;
            this.dgvPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonel.Size = new System.Drawing.Size(804, 664);
            this.dgvPersonel.TabIndex = 1;
            // 
            // UC_Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPersonel);
            this.Controls.Add(this.tlpPersonel);
            this.Name = "UC_Personel";
            this.Size = new System.Drawing.Size(804, 844);
            this.Load += new System.EventHandler(this.UC_Personel_Load);
            this.tlpPersonel.ResumeLayout(false);
            this.tlpPersonel.PerformLayout();
            this.flpPersButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPersonel;
        private System.Windows.Forms.Label lblPersAd;
        private System.Windows.Forms.Label lblPersSoyad;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtPersAd;
        private System.Windows.Forms.TextBox txtPersSoyad;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.TextBox txtEmailPers;
        private System.Windows.Forms.TextBox txtTelefonPers;
        private System.Windows.Forms.FlowLayoutPanel flpPersButtons;
        private System.Windows.Forms.Button btnPersEkle;
        private System.Windows.Forms.Button btnPersGuncelle;
        private System.Windows.Forms.Button btnPersSil;
        private System.Windows.Forms.DataGridView dgvPersonel;
    }
}
