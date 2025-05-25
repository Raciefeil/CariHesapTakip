using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CariHesapTakip.Data;
using CariHesapTakip.Models;

namespace CariHesapTakip.UI.Controls
{
    public partial class UC_CariHareket : UserControl
    {
        private readonly CariContext db;

        public UC_CariHareket()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                db = new CariContext();

                // Load ve event handler bağlamaları
                this.Load += UC_CariHareket_Load;
                dgvHareket.SelectionChanged += DgvHareket_SelectionChanged;
                btnHareketEkle.Click += BtnHareketEkle_Click;
                btnHareketGuncelle.Click += BtnHareketGuncelle_Click;
                btnHareketSil.Click += BtnHareketSil_Click;
            }
        }

        private void UC_CariHareket_Load(object sender, EventArgs e)
        {
            // 1) Cari hesapları önce SQL’den çek, sonra bellekte Display oluştur
            var tempCari = db.CariHesaplar
                .Include(c => c.Musteri)
                .Select(c => new
                {
                    c.Id,
                    c.HesapKodu,
                    MusteriAd = c.Musteri.Ad,
                    MusteriSoyad = c.Musteri.Soyad
                })
                .ToList();
            var listCari = tempCari
                .Select(c => new
                {
                    c.Id,
                    Display = $"{c.HesapKodu} ({c.MusteriAd} {c.MusteriSoyad})"
                })
                .ToList();
            cmbCari.DataSource = listCari;
            cmbCari.ValueMember = "Id";
            cmbCari.DisplayMember = "Display";
            cmbCari.SelectedIndex = -1;

            // 2) Personel listesini doldur
            var tempPers = db.Personeller
                .Select(p => new
                {
                    p.Id,
                    p.Ad,
                    p.Soyad
                })
                .ToList();
            var listPers = tempPers
                .Select(p => new
                {
                    p.Id,
                    Display = $"{p.Ad} {p.Soyad}"
                })
                .ToList();
            cmbPersonel.DataSource = listPers;
            cmbPersonel.ValueMember = "Id";
            cmbPersonel.DisplayMember = "Display";
            cmbPersonel.SelectedIndex = -1;

            // 3) Ürün listesini doldur
            var tempUrun = db.Urunler
                .Select(u => new
                {
                    u.Id,
                    u.Ad
                })
                .ToList();
            var listUrun = tempUrun
                .Select(u => new
                {
                    u.Id,
                    Display = u.Ad
                })
                .ToList();
            cmbUrun.DataSource = listUrun;
            cmbUrun.ValueMember = "Id";
            cmbUrun.DisplayMember = "Display";
            cmbUrun.SelectedIndex = -1;

            // 4) Ödeme tiplerini doldur
            var tempOdeme = db.OdemeTipleri
                .Select(o => new
                {
                    o.Id,
                    o.TipAdi
                })
                .ToList();
            var listOdeme = tempOdeme
                .Select(o => new
                {
                    o.Id,
                    Display = o.TipAdi
                })
                .ToList();
            cmbOdemeTipi.DataSource = listOdeme;
            cmbOdemeTipi.ValueMember = "Id";
            cmbOdemeTipi.DisplayMember = "Display";
            cmbOdemeTipi.SelectedIndex = -1;

            // 5) Tüm hareketleri yükle
            LoadHareketler();

            // 6) Formu temizle
            ClearForm();
        }

        private void LoadHareketler()
        {
            var liste = db.Hareketler
                .Include(h => h.CariHesap)
                .Include(h => h.Personel)
                .Include(h => h.Urun)
                .Include(h => h.OdemeTipi)
                .Select(h => new
                {
                    h.Id,
                    Cari = h.CariHesap.HesapKodu,
                    Tarih = h.Tarih,
                    Miktar = h.Miktar,
                    Tutar = h.Tutar,
                    Açıklama = h.Aciklama
                })
                .ToList();

            dgvHareket.DataSource = liste;

            if (dgvHareket.Columns["Id"] != null)
                dgvHareket.Columns["Id"].Visible = false;
        }

        private void BtnHareketEkle_Click(object sender, EventArgs e)
        {
            // 1) Zorunlu seçimlerin kontrolü
            if (cmbCari.SelectedIndex < 0)
            {
                MessageBox.Show("Önce bir cari hesap seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbPersonel.SelectedIndex < 0)
            {
                MessageBox.Show("Önce bir personel seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbUrun.SelectedIndex < 0)
            {
                MessageBox.Show("Önce bir ürün seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbOdemeTipi.SelectedIndex < 0)
            {
                MessageBox.Show("Önce bir ödeme tipi seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Yeni hareket nesnesini oluştur
            var h = new CariHareket
            {
                CariHesapId = (int)cmbCari.SelectedValue,
                PersonelId = (int)cmbPersonel.SelectedValue,
                UrunId = (int)cmbUrun.SelectedValue,
                OdemeTipiId = (int)cmbOdemeTipi.SelectedValue,
                Tarih = dtpTarih.Value,
                Miktar = (int)nudMiktar.Value,
                Tutar = decimal.TryParse(txtTutar.Text, out var t) ? t : 0m,
                Aciklama = ""
            };

            db.Hareketler.Add(h);
            db.SaveChanges();

            LoadHareketler();

            // Burada ClearForm()’u çağırıyoruz:
            ClearForm();
        }

        /// <summary>
        /// Formu varsayılan durumuna çevirir, tüm seçimleri sıfırlar.
        /// </summary>
        private void ClearForm()
        {
            cmbCari.SelectedIndex = -1;
            cmbPersonel.SelectedIndex = -1;
            cmbUrun.SelectedIndex = -1;
            cmbOdemeTipi.SelectedIndex = -1;

            dtpTarih.Value = DateTime.Now;
            nudMiktar.Value = 0;
            txtTutar.Clear();

            dgvHareket.ClearSelection();
        }

        private void DgvHareket_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHareket.CurrentRow == null) return;

            int id = (int)dgvHareket.CurrentRow.Cells["Id"].Value;
            var h = db.Hareketler.Find(id);
            if (h == null) return;

            cmbCari.SelectedValue = h.CariHesapId;
            dtpTarih.Value = h.Tarih;
            nudMiktar.Value = h.Miktar;
            txtTutar.Text = h.Tutar.ToString();
        }

        private void BtnHareketGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvHareket.CurrentRow == null) return;

            int id = (int)dgvHareket.CurrentRow.Cells["Id"].Value;
            var h = db.Hareketler.Find(id);
            if (h == null) return;

            h.CariHesapId = (int)cmbCari.SelectedValue;
            h.Tarih = dtpTarih.Value;
            h.Miktar = (int)nudMiktar.Value;
            h.Tutar = decimal.TryParse(txtTutar.Text, out var t) ? t : h.Tutar;
            h.PersonelId = (int)cmbPersonel.SelectedValue;
            h.UrunId = (int)cmbUrun.SelectedValue;
            h.OdemeTipiId = (int)cmbOdemeTipi.SelectedValue;

            db.SaveChanges();
            LoadHareketler();
        }

        private void BtnHareketSil_Click(object sender, EventArgs e)
        {
            if (dgvHareket.CurrentRow == null) return;

            int id = (int)dgvHareket.CurrentRow.Cells["Id"].Value;
            var h = db.Hareketler.Find(id);
            if (h == null) return;

            if (MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            db.Hareketler.Remove(h);
            db.SaveChanges();
            LoadHareketler();
        }

        private void btnHareketSil_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbCari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMiktar_Click(object sender, EventArgs e)
        {

        }
    }
}
