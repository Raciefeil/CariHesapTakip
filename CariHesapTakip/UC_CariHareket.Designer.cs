namespace CariHesapTakip.UI.Controls
{
    partial class UC_CariHareket
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
            this.tlpHareket = new System.Windows.Forms.TableLayoutPanel();
            this.lblCari = new System.Windows.Forms.Label();
            this.cmbCari = new System.Windows.Forms.ComboBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.flpHButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHareketEkle = new System.Windows.Forms.Button();
            this.btnHareketGuncelle = new System.Windows.Forms.Button();
            this.btnHareketSil = new System.Windows.Forms.Button();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.dgvHareket = new System.Windows.Forms.DataGridView();
            this.tlpHareket.SuspendLayout();
            this.flpHButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpHareket
            // 
            this.tlpHareket.ColumnCount = 6;
            this.tlpHareket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHareket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.65072F));
            this.tlpHareket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.84689F));
            this.tlpHareket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.50239F));
            this.tlpHareket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tlpHareket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tlpHareket.Controls.Add(this.lblCari, 0, 0);
            this.tlpHareket.Controls.Add(this.cmbCari, 1, 0);
            this.tlpHareket.Controls.Add(this.lblTarih, 0, 1);
            this.tlpHareket.Controls.Add(this.dtpTarih, 1, 1);
            this.tlpHareket.Controls.Add(this.flpHButtons, 0, 2);
            this.tlpHareket.Controls.Add(this.nudMiktar, 5, 0);
            this.tlpHareket.Controls.Add(this.txtTutar, 5, 1);
            this.tlpHareket.Controls.Add(this.lblTutar, 4, 1);
            this.tlpHareket.Controls.Add(this.lblMiktar, 4, 0);
            this.tlpHareket.Controls.Add(this.cmbUrun, 3, 0);
            this.tlpHareket.Controls.Add(this.cmbOdemeTipi, 3, 1);
            this.tlpHareket.Controls.Add(this.cmbPersonel, 2, 0);
            this.tlpHareket.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHareket.Location = new System.Drawing.Point(0, 0);
            this.tlpHareket.Name = "tlpHareket";
            this.tlpHareket.RowCount = 3;
            this.tlpHareket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpHareket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpHareket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHareket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpHareket.Size = new System.Drawing.Size(1134, 112);
            this.tlpHareket.TabIndex = 0;
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCari.Location = new System.Drawing.Point(5, 5);
            this.lblCari.Margin = new System.Windows.Forms.Padding(5);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(163, 22);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "Cari Kart:";
            this.lblCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCari
            // 
            this.cmbCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCari.FormattingEnabled = true;
            this.cmbCari.Location = new System.Drawing.Point(176, 3);
            this.cmbCari.Name = "cmbCari";
            this.cmbCari.Size = new System.Drawing.Size(143, 29);
            this.cmbCari.TabIndex = 1;
            this.cmbCari.SelectedIndexChanged += new System.EventHandler(this.cmbCari_SelectedIndexChanged);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarih.Location = new System.Drawing.Point(5, 37);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(5);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(163, 18);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih:";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(176, 35);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(143, 29);
            this.dtpTarih.TabIndex = 3;
            // 
            // flpHButtons
            // 
            this.tlpHareket.SetColumnSpan(this.flpHButtons, 6);
            this.flpHButtons.Controls.Add(this.btnHareketEkle);
            this.flpHButtons.Controls.Add(this.btnHareketGuncelle);
            this.flpHButtons.Controls.Add(this.btnHareketSil);
            this.flpHButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHButtons.Location = new System.Drawing.Point(3, 63);
            this.flpHButtons.Name = "flpHButtons";
            this.flpHButtons.Size = new System.Drawing.Size(1128, 46);
            this.flpHButtons.TabIndex = 8;
            this.flpHButtons.WrapContents = false;
            // 
            // btnHareketEkle
            // 
            this.btnHareketEkle.Location = new System.Drawing.Point(5, 5);
            this.btnHareketEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnHareketEkle.Name = "btnHareketEkle";
            this.btnHareketEkle.Size = new System.Drawing.Size(125, 34);
            this.btnHareketEkle.TabIndex = 0;
            this.btnHareketEkle.Text = "Ekle";
            this.btnHareketEkle.UseVisualStyleBackColor = true;
            // 
            // btnHareketGuncelle
            // 
            this.btnHareketGuncelle.Location = new System.Drawing.Point(140, 5);
            this.btnHareketGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnHareketGuncelle.Name = "btnHareketGuncelle";
            this.btnHareketGuncelle.Size = new System.Drawing.Size(144, 34);
            this.btnHareketGuncelle.TabIndex = 1;
            this.btnHareketGuncelle.Text = "Güncelle";
            this.btnHareketGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnHareketSil
            // 
            this.btnHareketSil.Location = new System.Drawing.Point(294, 5);
            this.btnHareketSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnHareketSil.Name = "btnHareketSil";
            this.btnHareketSil.Size = new System.Drawing.Size(118, 34);
            this.btnHareketSil.TabIndex = 2;
            this.btnHareketSil.Text = "Sil";
            this.btnHareketSil.UseVisualStyleBackColor = true;
            this.btnHareketSil.Click += new System.EventHandler(this.btnHareketSil_Click_1);
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(912, 3);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(218, 29);
            this.nudMiktar.TabIndex = 5;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(914, 37);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(5);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(214, 29);
            this.txtTutar.TabIndex = 7;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(696, 37);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(5);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(49, 18);
            this.lblTutar.TabIndex = 6;
            this.lblTutar.Text = "Tutar:";
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(696, 5);
            this.lblMiktar.Margin = new System.Windows.Forms.Padding(5);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(58, 21);
            this.lblMiktar.TabIndex = 4;
            this.lblMiktar.Text = "Miktar:";
            this.lblMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMiktar.Click += new System.EventHandler(this.lblMiktar_Click);
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(483, 3);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(205, 29);
            this.cmbUrun.TabIndex = 9;
            // 
            // cmbOdemeTipi
            // 
            this.cmbOdemeTipi.FormattingEnabled = true;
            this.cmbOdemeTipi.Location = new System.Drawing.Point(483, 35);
            this.cmbOdemeTipi.Name = "cmbOdemeTipi";
            this.cmbOdemeTipi.Size = new System.Drawing.Size(205, 29);
            this.cmbOdemeTipi.TabIndex = 10;
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(325, 3);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(152, 29);
            this.cmbPersonel.TabIndex = 11;
            // 
            // dgvHareket
            // 
            this.dgvHareket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHareket.Location = new System.Drawing.Point(0, 112);
            this.dgvHareket.Name = "dgvHareket";
            this.dgvHareket.ReadOnly = true;
            this.dgvHareket.RowHeadersWidth = 62;
            this.dgvHareket.RowTemplate.Height = 28;
            this.dgvHareket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHareket.Size = new System.Drawing.Size(1134, 915);
            this.dgvHareket.TabIndex = 1;
            // 
            // UC_CariHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.dgvHareket);
            this.Controls.Add(this.tlpHareket);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "UC_CariHareket";
            this.Size = new System.Drawing.Size(1134, 1027);
            this.Load += new System.EventHandler(this.UC_CariHareket_Load);
            this.tlpHareket.ResumeLayout(false);
            this.tlpHareket.PerformLayout();
            this.flpHButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpHareket;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.ComboBox cmbCari;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.FlowLayoutPanel flpHButtons;
        private System.Windows.Forms.Button btnHareketEkle;
        private System.Windows.Forms.Button btnHareketGuncelle;
        private System.Windows.Forms.Button btnHareketSil;
        private System.Windows.Forms.DataGridView dgvHareket;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.ComboBox cmbOdemeTipi;
        private System.Windows.Forms.ComboBox cmbPersonel;
    }
}
