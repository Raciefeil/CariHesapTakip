using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CariHesapTakip.Data;
using CariHesapTakip.Models;

namespace CariHesapTakip.UI.Controls
{
    public partial class UC_Dashboard : UserControl
    {
        private readonly CariContext db;

        public UC_Dashboard()
        {
            InitializeComponent();

            // Tasarım zamanında çalıştırmayı atla
            if (!DesignMode)
            {
                db = new CariContext();
                this.Load += UC_Dashboard_Load;
            }
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {// 0) Tüm hareketleri, cari hesapları ve müşterileri önce belleğe al:
            var allHareketler = db.Hareketler.ToList();
            var allCariHesaplar = db.CariHesaplar
                                    .Include(c => c.Musteri)
                                    .ToList();

            // 1) Kartlardaki metrikler
            lblTotalCustomersValue.Text = db.Musteriler.Count().ToString();
            lblTotalAccountsValue.Text = allCariHesaplar.Count().ToString();

            // Bellekte toplama yapılacağından artık null problemi kalmaz
            var totalBalance = allCariHesaplar.Sum(c => c.Bakiye);
            lblTotalBalanceValue.Text = totalBalance.ToString("N2");

            lblTotalMovementsValue.Text = allHareketler.Count.ToString();

            // 2) Aylık hareket toplamları (bellekte)
            var data = allHareketler
                .GroupBy(h => new { h.Tarih.Year, h.Tarih.Month })
                .Select(g => new
                {
                    Month = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Total = g.Sum(h => h.Tutar)
                })
                .OrderBy(x => x.Month)
                .ToList();

            // 3) Chart ayarları
            chartMonthlyMovements.Series.Clear();
            var series = new Series("Aylık Tutar")
            {
                ChartType = SeriesChartType.Line,
                XValueMember = "Month",
                YValueMembers = "Total"
            };
            chartMonthlyMovements.Series.Add(series);

            var area = chartMonthlyMovements.ChartAreas[0];
            area.AxisX.LabelStyle.Format = "MMM yy";
            area.AxisX.IntervalType = DateTimeIntervalType.Months;
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chartMonthlyMovements.DataSource = data;
            chartMonthlyMovements.DataBind();
        }
    }
}
