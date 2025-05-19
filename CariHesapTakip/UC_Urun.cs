using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CariHesapTakip.Data;
using CariHesapTakip.Models;

namespace CariHesapTakip.UI.Controls
{
    public partial class UC_Urun : UserControl
    {
        private readonly CariContext db;

        public UC_Urun()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                db = new CariContext();
                this.Load += UC_Urun_Load;
                dgvUrun.SelectionChanged += DgvUrun_SelectionChanged;
                btnUrunEkle.Click += BtnUrunEkle_Click;
                btnUrunGuncelle.Click += BtnUrunGuncelle_Click;
                btnUrunSil.Click += BtnUrunSil_Click;
            }
        }

        private void UC_Urun_Load(object sender, EventArgs e)
        {
            LoadUrunler();
        }

        private void LoadUrunler()
        {
            var liste = db.Urunler
                .Select(u => new
                {
                    u.Id,
                    u.Ad,
                    u.BirimFiyat,
                    u.Kategori,
                    Stok = u.StokMiktar
                })
                .ToList();

            dgvUrun.DataSource = liste;

            if (dgvUrun.Columns["Id"] != null)
                dgvUrun.Columns["Id"].Visible = false;
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            // Basit validasyon
            if (string.IsNullOrWhiteSpace(txtUrunAd.Text))
            {
                MessageBox.Show("Ürün adı girmelisiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var u = new Urun
            {
                Ad = txtUrunAd.Text.Trim(),
                BirimFiyat = decimal.TryParse(txtBirimFiyat.Text, out var f) ? f : 0,
                Kategori = txtKategori.Text.Trim(),
                StokMiktar = (int)nudStokMiktar.Value
            };

            db.Urunler.Add(u);
            db.SaveChanges();
            LoadUrunler();
        }

        private void DgvUrun_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUrun.CurrentRow == null) return;

            int id = (int)dgvUrun.CurrentRow.Cells["Id"].Value;
            var u = db.Urunler.Find(id);
            if (u == null) return;

            txtUrunAd.Text = u.Ad;
            txtBirimFiyat.Text = u.BirimFiyat.ToString();
            txtKategori.Text = u.Kategori;
            nudStokMiktar.Value = u.StokMiktar;
        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrun.CurrentRow == null) return;

            int id = (int)dgvUrun.CurrentRow.Cells["Id"].Value;
            var u = db.Urunler.Find(id);
            if (u == null) return;

            u.Ad = txtUrunAd.Text.Trim();
            u.BirimFiyat = decimal.TryParse(txtBirimFiyat.Text, out var f2) ? f2 : u.BirimFiyat;
            u.Kategori = txtKategori.Text.Trim();
            u.StokMiktar = (int)nudStokMiktar.Value;

            db.SaveChanges();
            LoadUrunler();
        }

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            if (dgvUrun.CurrentRow == null) return;

            int id = (int)dgvUrun.CurrentRow.Cells["Id"].Value;
            var u = db.Urunler.Find(id);
            if (u == null) return;

            if (MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            db.Urunler.Remove(u);
            db.SaveChanges();
            LoadUrunler();
        }
    }
}
