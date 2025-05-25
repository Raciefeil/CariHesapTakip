namespace CariHesapTakip.UI.Controls
{
    partial class UC_Rapor
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
            this.tlpRapor = new System.Windows.Forms.TableLayoutPanel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnRaporGetir = new System.Windows.Forms.Button();
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.tlpRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRapor
            // 
            this.tlpRapor.ColumnCount = 3;
            this.tlpRapor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpRapor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpRapor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpRapor.Controls.Add(this.lblFrom, 0, 0);
            this.tlpRapor.Controls.Add(this.dtpFrom, 1, 0);
            this.tlpRapor.Controls.Add(this.lblTo, 2, 0);
            this.tlpRapor.Controls.Add(this.dtpTo, 0, 1);
            this.tlpRapor.Controls.Add(this.btnRaporGetir, 2, 1);
            this.tlpRapor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpRapor.Location = new System.Drawing.Point(0, 0);
            this.tlpRapor.Name = "tlpRapor";
            this.tlpRapor.RowCount = 2;
            this.tlpRapor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpRapor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpRapor.Size = new System.Drawing.Size(812, 60);
            this.tlpRapor.TabIndex = 0;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFrom.Location = new System.Drawing.Point(5, 5);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(5);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(274, 20);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Başlangıç:";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(287, 3);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(278, 26);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTo.Location = new System.Drawing.Point(573, 5);
            this.lblTo.Margin = new System.Windows.Forms.Padding(5);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(234, 20);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Bitiş:";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpTo
            // 
            this.tlpRapor.SetColumnSpan(this.dtpTo, 2);
            this.dtpTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(3, 33);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(562, 26);
            this.dtpTo.TabIndex = 3;
            // 
            // btnRaporGetir
            // 
            this.btnRaporGetir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRaporGetir.Location = new System.Drawing.Point(568, 30);
            this.btnRaporGetir.Margin = new System.Windows.Forms.Padding(0);
            this.btnRaporGetir.Name = "btnRaporGetir";
            this.btnRaporGetir.Size = new System.Drawing.Size(244, 30);
            this.btnRaporGetir.TabIndex = 4;
            this.btnRaporGetir.Text = "Raporu Getir";
            this.btnRaporGetir.UseVisualStyleBackColor = true;
            this.btnRaporGetir.Click += new System.EventHandler(this.btnRaporGetir_Click_1);
            // 
            // dgvRapor
            // 
            this.dgvRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRapor.Location = new System.Drawing.Point(0, 60);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.RowHeadersWidth = 62;
            this.dgvRapor.RowTemplate.Height = 28;
            this.dgvRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRapor.Size = new System.Drawing.Size(812, 587);
            this.dgvRapor.TabIndex = 1;
            // 
            // UC_Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.dgvRapor);
            this.Controls.Add(this.tlpRapor);
            this.Name = "UC_Rapor";
            this.Size = new System.Drawing.Size(812, 647);
            this.Load += new System.EventHandler(this.UC_Rapor_Load);
            this.tlpRapor.ResumeLayout(false);
            this.tlpRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRapor;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnRaporGetir;
        private System.Windows.Forms.DataGridView dgvRapor;
    }
}
