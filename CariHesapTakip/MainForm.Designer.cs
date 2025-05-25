namespace CariHesapTakip
{
    partial class MainForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnOdemeTipi = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnHareket = new System.Windows.Forms.Button();
            this.btnCariKart = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnKapat);
            this.panelTop.Controls.Add(this.lblBaslık);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 100);
            this.panelTop.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Location = new System.Drawing.Point(709, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(91, 100);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBaslık.Location = new System.Drawing.Point(0, 0);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblBaslık.Size = new System.Drawing.Size(189, 21);
            this.lblBaslık.TabIndex = 0;
            this.lblBaslık.Text = "Cari Hesap Takip Sistemi";
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.btnRapor);
            this.panelSidebar.Controls.Add(this.btnOdemeTipi);
            this.panelSidebar.Controls.Add(this.btnPersonel);
            this.panelSidebar.Controls.Add(this.btnUrun);
            this.panelSidebar.Controls.Add(this.btnHareket);
            this.panelSidebar.Controls.Add(this.btnCariKart);
            this.panelSidebar.Controls.Add(this.btnMusteri);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 100);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 494);
            this.panelSidebar.TabIndex = 2;
            // 
            // btnRapor
            // 
            this.btnRapor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRapor.Location = new System.Drawing.Point(0, 433);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(200, 61);
            this.btnRapor.TabIndex = 6;
            this.btnRapor.Text = "Raporlar";
            this.btnRapor.UseVisualStyleBackColor = true;
            // 
            // btnOdemeTipi
            // 
            this.btnOdemeTipi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOdemeTipi.Location = new System.Drawing.Point(0, 362);
            this.btnOdemeTipi.Name = "btnOdemeTipi";
            this.btnOdemeTipi.Size = new System.Drawing.Size(200, 71);
            this.btnOdemeTipi.TabIndex = 5;
            this.btnOdemeTipi.Text = "Ödeme Tipi";
            this.btnOdemeTipi.UseVisualStyleBackColor = true;
            // 
            // btnPersonel
            // 
            this.btnPersonel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnPersonel.Location = new System.Drawing.Point(0, 293);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(200, 69);
            this.btnPersonel.TabIndex = 4;
            this.btnPersonel.Text = "Personeller";
            this.btnPersonel.UseVisualStyleBackColor = true;
            // 
            // btnUrun
            // 
            this.btnUrun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrun.Location = new System.Drawing.Point(0, 229);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(200, 64);
            this.btnUrun.TabIndex = 3;
            this.btnUrun.Text = "Ürünler";
            this.btnUrun.UseVisualStyleBackColor = true;
            // 
            // btnHareket
            // 
            this.btnHareket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHareket.Location = new System.Drawing.Point(0, 156);
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.Size = new System.Drawing.Size(200, 73);
            this.btnHareket.TabIndex = 2;
            this.btnHareket.Text = "Hareketler";
            this.btnHareket.UseVisualStyleBackColor = true;
            // 
            // btnCariKart
            // 
            this.btnCariKart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCariKart.Location = new System.Drawing.Point(0, 83);
            this.btnCariKart.Name = "btnCariKart";
            this.btnCariKart.Size = new System.Drawing.Size(200, 73);
            this.btnCariKart.TabIndex = 1;
            this.btnCariKart.Text = "Cari Kartlar";
            this.btnCariKart.UseVisualStyleBackColor = true;
            // 
            // btnMusteri
            // 
            this.btnMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusteri.Location = new System.Drawing.Point(0, 0);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(200, 83);
            this.btnMusteri.TabIndex = 0;
            this.btnMusteri.Text = "Müşteriler";
            this.btnMusteri.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(600, 494);
            this.panelContent.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 594);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Cari Hesap Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnOdemeTipi;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnHareket;
        private System.Windows.Forms.Button btnCariKart;
        private System.Windows.Forms.Button btnMusteri;
    }
}