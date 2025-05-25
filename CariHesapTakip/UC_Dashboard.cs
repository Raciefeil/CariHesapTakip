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
        {
            // 1) Temel metrikleri alıp kartlardaki label'lara yaz
            lblTotalCustomersValue.Text = db.Musteriler.Count().ToString();
            lblTotalAccountsValue.Text = db.CariHesaplar.Count().ToString();
            lblTotalBalanceValue.Text = db.CariHesaplar.Sum(c => c.Bakiye).ToString("N2");
            lblTotalMovementsValue.Text = db.Hareketler.Count().ToString();

            // 2) Aylık hareket toplamlarını gruplandır
            var data = db.Hareketler
                .GroupBy(h => new { h.Tarih.Year, h.Tarih.Month })
                .Select(g => new
                {
                    Month = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Total = g.Sum(h => h.Tutar)
                })
                .OrderBy(x => x.Month)
                .ToList();

            // 3) Chart'ı temizle ve yeni series ekle
            chartMonthlyMovements.Series.Clear();
            var series = new Series("Aylık Tutar")
            {
                ChartType = SeriesChartType.Line,
                XValueMember = "Month",
                YValueMembers = "Total"
            };
            chartMonthlyMovements.Series.Add(series);

            // 4) Ekseni biçimlendir
            var area = chartMonthlyMovements.ChartAreas[0];
            area.AxisX.LabelStyle.Format = "MMM yy";
            area.AxisX.IntervalType = DateTimeIntervalType.Months;
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // 5) Veriyi bağla ve çiz
            chartMonthlyMovements.DataSource = data;
            chartMonthlyMovements.DataBind();
        }
    }
}
