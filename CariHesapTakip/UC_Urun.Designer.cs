namespace CariHesapTakip.UI.Controls
{
    partial class UC_Urun
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
            this.components = new System.ComponentModel.Container();
            this.tlpUrun = new System.Windows.Forms.TableLayoutPanel();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.nudStokMiktar = new System.Windows.Forms.NumericUpDown();
            this.flpUrunButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvUrun = new System.Windows.Forms.DataGridView();
            this.tlpUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokMiktar)).BeginInit();
            this.flpUrunButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpUrun
            // 
            this.tlpUrun.ColumnCount = 2;
            this.tlpUrun.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpUrun.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpUrun.Controls.Add(this.lblUrunAd, 0, 0);
            this.tlpUrun.Controls.Add(this.lblBirimFiyat, 0, 1);
            this.tlpUrun.Controls.Add(this.lblKategori, 0, 2);
            this.tlpUrun.Controls.Add(this.lblStok, 0, 3);
            this.tlpUrun.Controls.Add(this.txtUrunAd, 1, 0);
            this.tlpUrun.Controls.Add(this.txtBirimFiyat, 1, 1);
            this.tlpUrun.Controls.Add(this.txtKategori, 1, 2);
            this.tlpUrun.Controls.Add(this.nudStokMiktar, 1, 3);
            this.tlpUrun.Controls.Add(this.flpUrunButtons, 0, 4);
            this.tlpUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpUrun.Location = new System.Drawing.Point(0, 0);
            this.tlpUrun.Name = "tlpUrun";
            this.tlpUrun.RowCount = 5;
            this.tlpUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUrun.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpUrun.Size = new System.Drawing.Size(674, 160);
            this.tlpUrun.TabIndex = 0;
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUrunAd.Location = new System.Drawing.Point(5, 5);
            this.lblUrunAd.Margin = new System.Windows.Forms.Padding(5);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(192, 20);
            this.lblUrunAd.TabIndex = 0;
            this.lblUrunAd.Text = "Ürün Adı:";
            this.lblUrunAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBirimFiyat.Location = new System.Drawing.Point(5, 35);
            this.lblBirimFiyat.Margin = new System.Windows.Forms.Padding(5);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(192, 20);
            this.lblBirimFiyat.TabIndex = 1;
            this.lblBirimFiyat.Text = "Birim Fiyat:";
            this.lblBirimFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKategori.Location = new System.Drawing.Point(5, 65);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(5);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(192, 20);
            this.lblKategori.TabIndex = 2;
            this.lblKategori.Text = "Kategori:";
            this.lblKategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStok.Location = new System.Drawing.Point(5, 95);
            this.lblStok.Margin = new System.Windows.Forms.Padding(5);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(192, 20);
            this.lblStok.TabIndex = 3;
            this.lblStok.Text = "Stok Miktarı:";
            this.lblStok.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrunAd.Location = new System.Drawing.Point(205, 3);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(466, 26);
            this.txtUrunAd.TabIndex = 4;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBirimFiyat.Location = new System.Drawing.Point(205, 33);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(466, 26);
            this.txtBirimFiyat.TabIndex = 5;
            // 
            // txtKategori
            // 
            this.txtKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKategori.Location = new System.Drawing.Point(205, 63);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(466, 26);
            this.txtKategori.TabIndex = 6;
            // 
            // nudStokMiktar
            // 
            this.nudStokMiktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudStokMiktar.Location = new System.Drawing.Point(205, 93);
            this.nudStokMiktar.Name = "nudStokMiktar";
            this.nudStokMiktar.Size = new System.Drawing.Size(466, 26);
            this.nudStokMiktar.TabIndex = 7;
            // 
            // flpUrunButtons
            // 
            this.tlpUrun.SetColumnSpan(this.flpUrunButtons, 2);
            this.flpUrunButtons.Controls.Add(this.btnUrunEkle);
            this.flpUrunButtons.Controls.Add(this.btnUrunGuncelle);
            this.flpUrunButtons.Controls.Add(this.btnUrunSil);
            this.flpUrunButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpUrunButtons.Location = new System.Drawing.Point(3, 123);
            this.flpUrunButtons.Name = "flpUrunButtons";
            this.flpUrunButtons.Size = new System.Drawing.Size(668, 34);
            this.flpUrunButtons.TabIndex = 8;
            this.flpUrunButtons.WrapContents = false;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(5, 5);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(107, 34);
            this.btnUrunEkle.TabIndex = 0;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click_1);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(122, 5);
            this.btnUrunGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(133, 34);
            this.btnUrunGuncelle.TabIndex = 1;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(265, 5);
            this.btnUrunSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(135, 39);
            this.btnUrunSil.TabIndex = 2;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvUrun
            // 
            this.dgvUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUrun.Location = new System.Drawing.Point(0, 160);
            this.dgvUrun.Name = "dgvUrun";
            this.dgvUrun.ReadOnly = true;
            this.dgvUrun.RowHeadersWidth = 62;
            this.dgvUrun.RowTemplate.Height = 28;
            this.dgvUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrun.Size = new System.Drawing.Size(674, 635);
            this.dgvUrun.TabIndex = 2;
            // 
            // UC_Urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.dgvUrun);
            this.Controls.Add(this.tlpUrun);
            this.Name = "UC_Urun";
            this.Size = new System.Drawing.Size(674, 795);
            this.Load += new System.EventHandler(this.UC_Urun_Load);
            this.tlpUrun.ResumeLayout(false);
            this.tlpUrun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokMiktar)).EndInit();
            this.flpUrunButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUrun;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.NumericUpDown nudStokMiktar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flpUrunButtons;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.DataGridView dgvUrun;
    }
}
