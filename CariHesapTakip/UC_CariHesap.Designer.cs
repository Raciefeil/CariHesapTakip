namespace CariHesapTakip
{
    partial class UC_CariHesap
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
            this.tlpCari = new System.Windows.Forms.TableLayoutPanel();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.lblHesapKodu = new System.Windows.Forms.Label();
            this.txtHesapKodu = new System.Windows.Forms.TextBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvCari = new System.Windows.Forms.DataGridView();
            this.tlpCari.SuspendLayout();
            this.flpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCari)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpCari
            // 
            this.tlpCari.ColumnCount = 2;
            this.tlpCari.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCari.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCari.Controls.Add(this.lblMusteri, 0, 0);
            this.tlpCari.Controls.Add(this.cmbMusteri, 1, 0);
            this.tlpCari.Controls.Add(this.lblHesapKodu, 0, 1);
            this.tlpCari.Controls.Add(this.txtHesapKodu, 1, 1);
            this.tlpCari.Controls.Add(this.txtBakiye, 1, 2);
            this.tlpCari.Controls.Add(this.lblBakiye, 0, 2);
            this.tlpCari.Controls.Add(this.flpButtons, 2, 3);
            this.tlpCari.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCari.Location = new System.Drawing.Point(0, 0);
            this.tlpCari.Name = "tlpCari";
            this.tlpCari.RowCount = 4;
            this.tlpCari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCari.Size = new System.Drawing.Size(603, 148);
            this.tlpCari.TabIndex = 0;
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMusteri.Location = new System.Drawing.Point(3, 0);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(295, 37);
            this.lblMusteri.TabIndex = 0;
            this.lblMusteri.Text = "Müşteri";
            this.lblMusteri.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(304, 3);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(296, 28);
            this.cmbMusteri.TabIndex = 1;
            // 
            // lblHesapKodu
            // 
            this.lblHesapKodu.AutoSize = true;
            this.lblHesapKodu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHesapKodu.Location = new System.Drawing.Point(3, 37);
            this.lblHesapKodu.Name = "lblHesapKodu";
            this.lblHesapKodu.Size = new System.Drawing.Size(295, 37);
            this.lblHesapKodu.TabIndex = 2;
            this.lblHesapKodu.Text = "Hesap Kodu";
            this.lblHesapKodu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHesapKodu
            // 
            this.txtHesapKodu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHesapKodu.Location = new System.Drawing.Point(304, 40);
            this.txtHesapKodu.Name = "txtHesapKodu";
            this.txtHesapKodu.Size = new System.Drawing.Size(296, 26);
            this.txtHesapKodu.TabIndex = 3;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBakiye.Location = new System.Drawing.Point(304, 77);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(296, 26);
            this.txtBakiye.TabIndex = 5;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBakiye.Location = new System.Drawing.Point(3, 74);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(295, 37);
            this.lblBakiye.TabIndex = 4;
            this.lblBakiye.Text = "Bakiye";
            this.lblBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnKaydet);
            this.flpButtons.Controls.Add(this.btnGuncelle);
            this.flpButtons.Controls.Add(this.btnSil);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.Location = new System.Drawing.Point(304, 114);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(296, 31);
            this.flpButtons.TabIndex = 6;
            this.flpButtons.WrapContents = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(5, 5);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 29);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(99, 5);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(97, 29);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(206, 5);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 28);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // dgvCari
            // 
            this.dgvCari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCari.Location = new System.Drawing.Point(0, 148);
            this.dgvCari.Name = "dgvCari";
            this.dgvCari.ReadOnly = true;
            this.dgvCari.RowHeadersWidth = 62;
            this.dgvCari.RowTemplate.Height = 28;
            this.dgvCari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCari.Size = new System.Drawing.Size(603, 445);
            this.dgvCari.TabIndex = 1;
            // 
            // UC_CariHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCari);
            this.Controls.Add(this.tlpCari);
            this.Name = "UC_CariHesap";
            this.Size = new System.Drawing.Size(603, 593);
            this.Load += new System.EventHandler(this.UC_CariHesap_Load);
            this.tlpCari.ResumeLayout(false);
            this.tlpCari.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCari;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label lblHesapKodu;
        private System.Windows.Forms.TextBox txtHesapKodu;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvCari;
    }
}
