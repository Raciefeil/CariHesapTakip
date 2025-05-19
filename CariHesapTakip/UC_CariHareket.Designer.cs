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
            this.lblMiktar = new System.Windows.Forms.Label();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.cmbCari = new System.Windows.Forms.ComboBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.flpHButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHareketEkle = new System.Windows.Forms.Button();
            this.btnHareketGuncelle = new System.Windows.Forms.Button();
            this.btnHareketSil = new System.Windows.Forms.Button();
            this.dgvHareket = new System.Windows.Forms.DataGridView();
            this.tlpHareket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            this.flpHButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareket)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpHareket
            // 
            this.tlpHareket.ColumnCount = 4;
            this.tlpHareket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHareket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHareket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHareket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHareket.Controls.Add(this.lblCari, 0, 0);
            this.tlpHareket.Controls.Add(this.lblMiktar, 2, 0);
            this.tlpHareket.Controls.Add(this.nudMiktar, 3, 0);
            this.tlpHareket.Controls.Add(this.cmbCari, 1, 0);
            this.tlpHareket.Controls.Add(this.lblTarih, 0, 1);
            this.tlpHareket.Controls.Add(this.dtpTarih, 1, 1);
            this.tlpHareket.Controls.Add(this.lblTutar, 2, 1);
            this.tlpHareket.Controls.Add(this.txtTutar, 3, 1);
            this.tlpHareket.Controls.Add(this.flpHButtons, 0, 2);
            this.tlpHareket.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpHareket.Location = new System.Drawing.Point(0, 0);
            this.tlpHareket.Name = "tlpHareket";
            this.tlpHareket.RowCount = 3;
            this.tlpHareket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHareket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHareket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpHareket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpHareket.Size = new System.Drawing.Size(711, 102);
            this.tlpHareket.TabIndex = 0;
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCari.Location = new System.Drawing.Point(5, 5);
            this.lblCari.Margin = new System.Windows.Forms.Padding(5);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(167, 20);
            this.lblCari.TabIndex = 0;
            this.lblCari.Text = "Cari Kart:";
            this.lblCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMiktar.Location = new System.Drawing.Point(359, 5);
            this.lblMiktar.Margin = new System.Windows.Forms.Padding(5);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(167, 20);
            this.lblMiktar.TabIndex = 4;
            this.lblMiktar.Text = "Miktar:";
            this.lblMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudMiktar
            // 
            this.nudMiktar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMiktar.Location = new System.Drawing.Point(534, 3);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(174, 26);
            this.nudMiktar.TabIndex = 5;
            // 
            // cmbCari
            // 
            this.cmbCari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCari.FormattingEnabled = true;
            this.cmbCari.Location = new System.Drawing.Point(180, 3);
            this.cmbCari.Name = "cmbCari";
            this.cmbCari.Size = new System.Drawing.Size(171, 28);
            this.cmbCari.TabIndex = 1;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTarih.Location = new System.Drawing.Point(5, 35);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(5);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(167, 20);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih:";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(180, 33);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(171, 26);
            this.dtpTarih.TabIndex = 3;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTutar.Location = new System.Drawing.Point(359, 35);
            this.lblTutar.Margin = new System.Windows.Forms.Padding(5);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(167, 20);
            this.lblTutar.TabIndex = 6;
            this.lblTutar.Text = "Tutar:";
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTutar
            // 
            this.txtTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTutar.Location = new System.Drawing.Point(536, 35);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(5);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(170, 26);
            this.txtTutar.TabIndex = 7;
            // 
            // flpHButtons
            // 
            this.tlpHareket.SetColumnSpan(this.flpHButtons, 4);
            this.flpHButtons.Controls.Add(this.btnHareketEkle);
            this.flpHButtons.Controls.Add(this.btnHareketGuncelle);
            this.flpHButtons.Controls.Add(this.btnHareketSil);
            this.flpHButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHButtons.Location = new System.Drawing.Point(3, 63);
            this.flpHButtons.Name = "flpHButtons";
            this.flpHButtons.Size = new System.Drawing.Size(705, 36);
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
            // 
            // dgvHareket
            // 
            this.dgvHareket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHareket.Location = new System.Drawing.Point(0, 102);
            this.dgvHareket.Name = "dgvHareket";
            this.dgvHareket.ReadOnly = true;
            this.dgvHareket.RowHeadersWidth = 62;
            this.dgvHareket.RowTemplate.Height = 28;
            this.dgvHareket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHareket.Size = new System.Drawing.Size(711, 483);
            this.dgvHareket.TabIndex = 1;
            // 
            // UC_CariHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvHareket);
            this.Controls.Add(this.tlpHareket);
            this.Name = "UC_CariHareket";
            this.Size = new System.Drawing.Size(711, 585);
            this.Load += new System.EventHandler(this.UC_CariHareket_Load);
            this.tlpHareket.ResumeLayout(false);
            this.tlpHareket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            this.flpHButtons.ResumeLayout(false);
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
    }
}
