using System;
using System.Data.Entity;           // Include() için
using System.Linq;
using System.Windows.Forms;
using CariHesapTakip.Data;          // DbContext’iniz
using CariHesapTakip.Models;        // Model sınıflarınız

namespace CariHesapTakip.UI.Controls
{
    public partial class UC_Rapor : UserControl
    {
        private readonly CariContext db;

        public UC_Rapor()
        {
            InitializeComponent();

            // Tasarım zamanında çalıştırma
            if (!DesignMode)
            {
                db = new CariContext();

                // Load eventi için handler
                this.Load += UC_Rapor_Load;

                // Rapor butonu için handler
                btnRaporGetir.Click += BtnRaporGetir_Click;
            }
        }

        // Designer’da referans verilen Load metodu
        private void UC_Rapor_Load(object sender, EventArgs e)
        {
            // İsteğe bağlı: default tarih aralıkları
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;
        }

        private void BtnRaporGetir_Click(object sender, EventArgs e)
        {
            // Tarih aralığını al
            var from = dtpFrom.Value.Date;
            var to = dtpTo.Value.Date.AddDays(1).AddSeconds(-1);

            // Veritabanından çek ve DataGridView’e ata
            var liste = db.Hareketler
                .Include(h => h.CariHesap)
                .Include(h => h.Personel)
                .Include(h => h.Urun)
                .Include(h => h.OdemeTipi)
                .Where(h => h.Tarih >= from && h.Tarih <= to)
                .Select(h => new
                {
                    h.Tarih,
                    Cari = h.CariHesap.HesapKodu,
                    Personel = h.Personel.Ad + " " + h.Personel.Soyad,
                    Urun = h.Urun.Ad,
                    OdemeTipi = h.OdemeTipi.TipAdi,
                    h.Miktar,
                    h.Tutar,
                    h.Aciklama
                })
                .ToList();

            dgvRapor.DataSource = liste;

            // İstersen Id sütununu gizle
            if (dgvRapor.Columns["Id"] != null)
                dgvRapor.Columns["Id"].Visible = false;
        }

        private void btnRaporGetir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
