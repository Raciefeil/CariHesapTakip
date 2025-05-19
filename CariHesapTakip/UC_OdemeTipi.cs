using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CariHesapTakip.Data;
using CariHesapTakip.Models;

namespace CariHesapTakip.UI.Controls
{
    public partial class UC_OdemeTipi : UserControl
    {
        private readonly CariContext db;

        public UC_OdemeTipi()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                db = new CariContext();

                // Event bağlamaları
                this.Load += UC_OdemeTipi_Load;
                dgvOdeme.SelectionChanged += DgvOdeme_SelectionChanged;
                btnOdemeEkle.Click += BtnOdemeEkle_Click;
                btnOdemeGuncelle.Click += BtnOdemeGuncelle_Click;
                btnOdemeSil.Click += BtnOdemeSil_Click;
            }
        }

        private void UC_OdemeTipi_Load(object sender, EventArgs e)
        {
            LoadOdemeTipleri();
        }

        private void LoadOdemeTipleri()
        {
            var liste = db.OdemeTipleri
                .Select(o => new
                {
                    o.Id,
                    o.TipAdi,
                    o.Aciklama
                })
                .ToList();

            dgvOdeme.DataSource = liste;

            if (dgvOdeme.Columns["Id"] != null)
                dgvOdeme.Columns["Id"].Visible = false;
        }

        private void DgvOdeme_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOdeme.CurrentRow == null) return;

            int id = (int)dgvOdeme.CurrentRow.Cells["Id"].Value;
            var o = db.OdemeTipleri.Find(id);
            if (o == null) return;

            txtTipAdi.Text = o.TipAdi;
            txtAciklama.Text = o.Aciklama;
        }

        private void BtnOdemeEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipAdi.Text))
            {
                MessageBox.Show("Önce ödeme tipi adı girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var o = new OdemeTipi
            {
                TipAdi = txtTipAdi.Text.Trim(),
                Aciklama = txtAciklama.Text.Trim()
            };

            db.OdemeTipleri.Add(o);
            db.SaveChanges();
            LoadOdemeTipleri();
        }

        private void BtnOdemeGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOdeme.CurrentRow == null) return;

            int id = (int)dgvOdeme.CurrentRow.Cells["Id"].Value;
            var o = db.OdemeTipleri.Find(id);
            if (o == null) return;

            o.TipAdi = txtTipAdi.Text.Trim();
            o.Aciklama = txtAciklama.Text.Trim();

            db.SaveChanges();
            LoadOdemeTipleri();
        }

        private void BtnOdemeSil_Click(object sender, EventArgs e)
        {
            if (dgvOdeme.CurrentRow == null) return;

            int id = (int)dgvOdeme.CurrentRow.Cells["Id"].Value;
            var o = db.OdemeTipleri.Find(id);
            if (o == null) return;

            if (MessageBox.Show("Seçili ödeme tipini silmek istediğinize emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            db.OdemeTipleri.Remove(o);
            db.SaveChanges();
            LoadOdemeTipleri();
        }
    }
}
