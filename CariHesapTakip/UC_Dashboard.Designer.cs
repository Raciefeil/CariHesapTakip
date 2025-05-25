namespace CariHesapTakip.UI.Controls
{
    partial class UC_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.flpMetrics = new System.Windows.Forms.FlowLayoutPanel();
            this.chartMonthlyMovements = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTotalCustomers = new System.Windows.Forms.Panel();
            this.lblTotalCustomersTitle = new System.Windows.Forms.Label();
            this.lblTotalCustomersValue = new System.Windows.Forms.Label();
            this.pnlTotalAccounts = new System.Windows.Forms.Panel();
            this.lblTotalAccountsValue = new System.Windows.Forms.Label();
            this.lblTotalAccountsTitle = new System.Windows.Forms.Label();
            this.pnlTotalBalance = new System.Windows.Forms.Panel();
            this.lblTotalBalanceValue = new System.Windows.Forms.Label();
            this.lblTotalBalanceTitle = new System.Windows.Forms.Label();
            this.pnlTotalMovements = new System.Windows.Forms.Panel();
            this.lblTotalMovementsValue = new System.Windows.Forms.Label();
            this.lblTotalMovementsTitle = new System.Windows.Forms.Label();
            this.flpMetrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyMovements)).BeginInit();
            this.pnlTotalCustomers.SuspendLayout();
            this.pnlTotalAccounts.SuspendLayout();
            this.pnlTotalBalance.SuspendLayout();
            this.pnlTotalMovements.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMetrics
            // 
            this.flpMetrics.Controls.Add(this.pnlTotalCustomers);
            this.flpMetrics.Controls.Add(this.pnlTotalAccounts);
            this.flpMetrics.Controls.Add(this.pnlTotalBalance);
            this.flpMetrics.Controls.Add(this.pnlTotalMovements);
            this.flpMetrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpMetrics.Location = new System.Drawing.Point(0, 0);
            this.flpMetrics.Name = "flpMetrics";
            this.flpMetrics.Padding = new System.Windows.Forms.Padding(10);
            this.flpMetrics.Size = new System.Drawing.Size(625, 120);
            this.flpMetrics.TabIndex = 0;
            // 
            // chartMonthlyMovements
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMonthlyMovements.ChartAreas.Add(chartArea2);
            this.chartMonthlyMovements.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartMonthlyMovements.Legends.Add(legend2);
            this.chartMonthlyMovements.Location = new System.Drawing.Point(0, 120);
            this.chartMonthlyMovements.Name = "chartMonthlyMovements";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMonthlyMovements.Series.Add(series2);
            this.chartMonthlyMovements.Size = new System.Drawing.Size(625, 542);
            this.chartMonthlyMovements.TabIndex = 1;
            this.chartMonthlyMovements.Text = "chart1";
            // 
            // pnlTotalCustomers
            // 
            this.pnlTotalCustomers.BackColor = System.Drawing.Color.White;
            this.pnlTotalCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalCustomers.Controls.Add(this.lblTotalCustomersValue);
            this.pnlTotalCustomers.Controls.Add(this.lblTotalCustomersTitle);
            this.pnlTotalCustomers.Location = new System.Drawing.Point(15, 15);
            this.pnlTotalCustomers.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTotalCustomers.Name = "pnlTotalCustomers";
            this.pnlTotalCustomers.Size = new System.Drawing.Size(138, 100);
            this.pnlTotalCustomers.TabIndex = 0;
            // 
            // lblTotalCustomersTitle
            // 
            this.lblTotalCustomersTitle.AutoSize = true;
            this.lblTotalCustomersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTotalCustomersTitle.Location = new System.Drawing.Point(3, 27);
            this.lblTotalCustomersTitle.Name = "lblTotalCustomersTitle";
            this.lblTotalCustomersTitle.Size = new System.Drawing.Size(125, 20);
            this.lblTotalCustomersTitle.TabIndex = 0;
            this.lblTotalCustomersTitle.Text = "Toplam Müşteri";
            this.lblTotalCustomersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomersValue
            // 
            this.lblTotalCustomersValue.AutoSize = true;
            this.lblTotalCustomersValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTotalCustomersValue.Location = new System.Drawing.Point(65, 61);
            this.lblTotalCustomersValue.Name = "lblTotalCustomersValue";
            this.lblTotalCustomersValue.Size = new System.Drawing.Size(18, 20);
            this.lblTotalCustomersValue.TabIndex = 1;
            this.lblTotalCustomersValue.Text = "0";
            this.lblTotalCustomersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
     //       this.lblTotalCustomersValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlTotalAccounts
            // 
            this.pnlTotalAccounts.BackColor = System.Drawing.Color.White;
            this.pnlTotalAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalAccounts.Controls.Add(this.lblTotalAccountsValue);
            this.pnlTotalAccounts.Controls.Add(this.lblTotalAccountsTitle);
            this.pnlTotalAccounts.Location = new System.Drawing.Point(163, 15);
            this.pnlTotalAccounts.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTotalAccounts.Name = "pnlTotalAccounts";
            this.pnlTotalAccounts.Size = new System.Drawing.Size(137, 100);
            this.pnlTotalAccounts.TabIndex = 1;
            // 
            // lblTotalAccountsValue
            // 
            this.lblTotalAccountsValue.AutoSize = true;
            this.lblTotalAccountsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTotalAccountsValue.Location = new System.Drawing.Point(65, 61);
            this.lblTotalAccountsValue.Name = "lblTotalAccountsValue";
            this.lblTotalAccountsValue.Size = new System.Drawing.Size(18, 20);
            this.lblTotalAccountsValue.TabIndex = 1;
            this.lblTotalAccountsValue.Text = "0";
            this.lblTotalAccountsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAccountsTitle
            // 
            this.lblTotalAccountsTitle.AutoSize = true;
            this.lblTotalAccountsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTotalAccountsTitle.Location = new System.Drawing.Point(3, 27);
            this.lblTotalAccountsTitle.Name = "lblTotalAccountsTitle";
            this.lblTotalAccountsTitle.Size = new System.Drawing.Size(126, 20);
            this.lblTotalAccountsTitle.TabIndex = 0;
            this.lblTotalAccountsTitle.Text = "Cari Kart Sayısı";
            this.lblTotalAccountsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalBalance
            // 
            this.pnlTotalBalance.BackColor = System.Drawing.Color.White;
            this.pnlTotalBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalBalance.Controls.Add(this.lblTotalBalanceValue);
            this.pnlTotalBalance.Controls.Add(this.lblTotalBalanceTitle);
            this.pnlTotalBalance.Location = new System.Drawing.Point(310, 15);
            this.pnlTotalBalance.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTotalBalance.Name = "pnlTotalBalance";
            this.pnlTotalBalance.Size = new System.Drawing.Size(126, 100);
            this.pnlTotalBalance.TabIndex = 2;
            // 
            // lblTotalBalanceValue
            // 
            this.lblTotalBalanceValue.AutoSize = true;
            this.lblTotalBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTotalBalanceValue.Location = new System.Drawing.Point(65, 61);
            this.lblTotalBalanceValue.Name = "lblTotalBalanceValue";
            this.lblTotalBalanceValue.Size = new System.Drawing.Size(18, 20);
            this.lblTotalBalanceValue.TabIndex = 1;
            this.lblTotalBalanceValue.Text = "0";
            this.lblTotalBalanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalBalanceTitle
            // 
            this.lblTotalBalanceTitle.AutoSize = true;
            this.lblTotalBalanceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTotalBalanceTitle.Location = new System.Drawing.Point(3, 27);
            this.lblTotalBalanceTitle.Name = "lblTotalBalanceTitle";
            this.lblTotalBalanceTitle.Size = new System.Drawing.Size(119, 20);
            this.lblTotalBalanceTitle.TabIndex = 0;
            this.lblTotalBalanceTitle.Text = "Toplam Bakiye";
            this.lblTotalBalanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalMovements
            // 
            this.pnlTotalMovements.BackColor = System.Drawing.Color.White;
            this.pnlTotalMovements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalMovements.Controls.Add(this.lblTotalMovementsValue);
            this.pnlTotalMovements.Controls.Add(this.lblTotalMovementsTitle);
            this.pnlTotalMovements.Location = new System.Drawing.Point(446, 15);
            this.pnlTotalMovements.Margin = new System.Windows.Forms.Padding(5);
            this.pnlTotalMovements.Name = "pnlTotalMovements";
            this.pnlTotalMovements.Size = new System.Drawing.Size(150, 100);
            this.pnlTotalMovements.TabIndex = 3;
            // 
            // lblTotalMovementsValue
            // 
            this.lblTotalMovementsValue.AutoSize = true;
            this.lblTotalMovementsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTotalMovementsValue.Location = new System.Drawing.Point(65, 61);
            this.lblTotalMovementsValue.Name = "lblTotalMovementsValue";
            this.lblTotalMovementsValue.Size = new System.Drawing.Size(18, 20);
            this.lblTotalMovementsValue.TabIndex = 1;
            this.lblTotalMovementsValue.Text = "0";
            this.lblTotalMovementsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMovementsTitle
            // 
            this.lblTotalMovementsTitle.AutoSize = true;
            this.lblTotalMovementsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblTotalMovementsTitle.Location = new System.Drawing.Point(16, 27);
            this.lblTotalMovementsTitle.Name = "lblTotalMovementsTitle";
            this.lblTotalMovementsTitle.Size = new System.Drawing.Size(115, 20);
            this.lblTotalMovementsTitle.TabIndex = 0;
            this.lblTotalMovementsTitle.Text = "Hareket Adedi";
            this.lblTotalMovementsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMonthlyMovements);
            this.Controls.Add(this.flpMetrics);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(625, 662);
            this.flpMetrics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyMovements)).EndInit();
            this.pnlTotalCustomers.ResumeLayout(false);
            this.pnlTotalCustomers.PerformLayout();
            this.pnlTotalAccounts.ResumeLayout(false);
            this.pnlTotalAccounts.PerformLayout();
            this.pnlTotalBalance.ResumeLayout(false);
            this.pnlTotalBalance.PerformLayout();
            this.pnlTotalMovements.ResumeLayout(false);
            this.pnlTotalMovements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMetrics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthlyMovements;
        private System.Windows.Forms.Panel pnlTotalCustomers;
        private System.Windows.Forms.Label lblTotalCustomersValue;
        private System.Windows.Forms.Label lblTotalCustomersTitle;
        private System.Windows.Forms.Panel pnlTotalAccounts;
        private System.Windows.Forms.Label lblTotalAccountsValue;
        private System.Windows.Forms.Label lblTotalAccountsTitle;
        private System.Windows.Forms.Panel pnlTotalBalance;
        private System.Windows.Forms.Label lblTotalBalanceValue;
        private System.Windows.Forms.Label lblTotalBalanceTitle;
        private System.Windows.Forms.Panel pnlTotalMovements;
        private System.Windows.Forms.Label lblTotalMovementsValue;
        private System.Windows.Forms.Label lblTotalMovementsTitle;
    }
}
