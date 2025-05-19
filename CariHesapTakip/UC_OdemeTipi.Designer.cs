namespace CariHesapTakip.UI.Controls
{
    partial class UC_OdemeTipi
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
            this.tlpOdeme = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipAdi = new System.Windows.Forms.Label();
            this.txtTipAdi = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOdemeEkle = new System.Windows.Forms.Button();
            this.btnOdemeGuncelle = new System.Windows.Forms.Button();
            this.btnOdemeSil = new System.Windows.Forms.Button();
            this.dgvOdeme = new System.Windows.Forms.DataGridView();
            this.tlpOdeme.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpOdeme
            // 
            this.tlpOdeme.ColumnCount = 2;
            this.tlpOdeme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpOdeme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpOdeme.Controls.Add(this.lblTipAdi, 0, 0);
            this.tlpOdeme.Controls.Add(this.txtTipAdi, 1, 0);
            this.tlpOdeme.Controls.Add(this.lblAciklama, 0, 1);
            this.tlpOdeme.Controls.Add(this.txtAciklama, 1, 1);
            this.tlpOdeme.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tlpOdeme.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpOdeme.Location = new System.Drawing.Point(0, 0);
            this.tlpOdeme.Name = "tlpOdeme";
            this.tlpOdeme.RowCount = 3;
            this.tlpOdeme.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOdeme.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpOdeme.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpOdeme.Size = new System.Drawing.Size(717, 140);
            this.tlpOdeme.TabIndex = 0;
            // 
            // lblTipAdi
            // 
            this.lblTipAdi.AutoSize = true;
            this.lblTipAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipAdi.Location = new System.Drawing.Point(5, 5);
            this.lblTipAdi.Margin = new System.Windows.Forms.Padding(5);
            this.lblTipAdi.Name = "lblTipAdi";
            this.lblTipAdi.Size = new System.Drawing.Size(205, 20);
            this.lblTipAdi.TabIndex = 0;
            this.lblTipAdi.Text = "Tip Adı:";
            this.lblTipAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTipAdi
            // 
            this.txtTipAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTipAdi.Location = new System.Drawing.Point(218, 3);
            this.txtTipAdi.Name = "txtTipAdi";
            this.txtTipAdi.Size = new System.Drawing.Size(496, 26);
            this.txtTipAdi.TabIndex = 1;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAciklama.Location = new System.Drawing.Point(5, 35);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(5);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(205, 20);
            this.lblAciklama.TabIndex = 2;
            this.lblAciklama.Text = "Açıklama:";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAciklama.Location = new System.Drawing.Point(218, 33);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(496, 26);
            this.txtAciklama.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.tlpOdeme.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnOdemeEkle);
            this.flowLayoutPanel1.Controls.Add(this.btnOdemeGuncelle);
            this.flowLayoutPanel1.Controls.Add(this.btnOdemeSil);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(711, 74);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnOdemeEkle
            // 
            this.btnOdemeEkle.Location = new System.Drawing.Point(5, 5);
            this.btnOdemeEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnOdemeEkle.Name = "btnOdemeEkle";
            this.btnOdemeEkle.Size = new System.Drawing.Size(202, 72);
            this.btnOdemeEkle.TabIndex = 0;
            this.btnOdemeEkle.Text = "Ekle";
            this.btnOdemeEkle.UseVisualStyleBackColor = true;
            // 
            // btnOdemeGuncelle
            // 
            this.btnOdemeGuncelle.Location = new System.Drawing.Point(217, 5);
            this.btnOdemeGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnOdemeGuncelle.Name = "btnOdemeGuncelle";
            this.btnOdemeGuncelle.Size = new System.Drawing.Size(271, 69);
            this.btnOdemeGuncelle.TabIndex = 1;
            this.btnOdemeGuncelle.Text = "Güncelle";
            this.btnOdemeGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnOdemeSil
            // 
            this.btnOdemeSil.Location = new System.Drawing.Point(498, 5);
            this.btnOdemeSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnOdemeSil.Name = "btnOdemeSil";
            this.btnOdemeSil.Size = new System.Drawing.Size(211, 69);
            this.btnOdemeSil.TabIndex = 2;
            this.btnOdemeSil.Text = "Sil";
            this.btnOdemeSil.UseVisualStyleBackColor = true;
            // 
            // dgvOdeme
            // 
            this.dgvOdeme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdeme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOdeme.Location = new System.Drawing.Point(0, 140);
            this.dgvOdeme.Name = "dgvOdeme";
            this.dgvOdeme.ReadOnly = true;
            this.dgvOdeme.RowHeadersWidth = 62;
            this.dgvOdeme.RowTemplate.Height = 28;
            this.dgvOdeme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdeme.Size = new System.Drawing.Size(717, 739);
            this.dgvOdeme.TabIndex = 1;
            // 
            // UC_OdemeTipi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvOdeme);
            this.Controls.Add(this.tlpOdeme);
            this.Name = "UC_OdemeTipi";
            this.Size = new System.Drawing.Size(717, 879);
            this.Load += new System.EventHandler(this.UC_OdemeTipi_Load);
            this.tlpOdeme.ResumeLayout(false);
            this.tlpOdeme.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdeme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOdeme;
        private System.Windows.Forms.Label lblTipAdi;
        private System.Windows.Forms.TextBox txtTipAdi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOdemeEkle;
        private System.Windows.Forms.Button btnOdemeGuncelle;
        private System.Windows.Forms.Button btnOdemeSil;
        private System.Windows.Forms.DataGridView dgvOdeme;
    }
}
