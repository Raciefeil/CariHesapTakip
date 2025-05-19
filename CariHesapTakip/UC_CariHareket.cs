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
            // ComboBox'a cari hesapları yükle
            cmbCari.DataSource = db.CariHesaplar
                .Include(c => c.Musteri)
                .Select(c => new
                {
                    c.Id,
                    Display = $"{c.HesapKodu} ({c.Musteri.Ad} {c.Musteri.Soyad})"
                })
                .ToList();

            cmbCari.DisplayMember = "Display";
            cmbCari.ValueMember = "Id";
            cmbCari.SelectedIndex = -1;

            // Listeyi doldur
            LoadHareketler();
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
            if (cmbCari.SelectedIndex < 0)
            {
                MessageBox.Show("Önce bir cari hesap seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var h = new CariHareket
            {
                CariHesapId = (int)cmbCari.SelectedValue,
                Tarih = dtpTarih.Value,
                Miktar = (int)nudMiktar.Value,
                Tutar = decimal.TryParse(txtTutar.Text, out var t) ? t : 0,
                Aciklama = "" // İstersen ayrı bir TextBox ekleyip alabilirsiniz
            };

            db.Hareketler.Add(h);
            db.SaveChanges();
            LoadHareketler();
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
    }
}
