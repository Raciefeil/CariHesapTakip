using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CariHesapTakip.Data;
using CariHesapTakip.Models;

namespace CariHesapTakip.UI.Controls
{
    public partial class UC_Personel : UserControl
    {
        private readonly CariContext db;

        public UC_Personel()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                db = new CariContext();

                this.Load += UC_Personel_Load;
                dgvPersonel.SelectionChanged += DgvPersonel_SelectionChanged;
                btnPersEkle.Click += BtnPersEkle_Click;
                btnPersGuncelle.Click += BtnPersGuncelle_Click;
                btnPersSil.Click += BtnPersSil_Click;
            }
        }

        private void UC_Personel_Load(object sender, EventArgs e)
        {
            LoadPersoneller();
        }

        private void LoadPersoneller()
        {
            var liste = db.Personeller
                .Select(p => new
                {
                    p.Id,
                    p.Ad,
                    p.Soyad,
                    p.Departman,
                    p.Email,
                    p.Telefon
                })
                .ToList();

            dgvPersonel.DataSource = liste;

            if (dgvPersonel.Columns["Id"] != null)
                dgvPersonel.Columns["Id"].Visible = false;
        }

        private void DgvPersonel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null) return;

            int id = (int)dgvPersonel.CurrentRow.Cells["Id"].Value;
            var p = db.Personeller.Find(id);
            if (p == null) return;

            txtPersAd.Text = p.Ad;
            txtPersSoyad.Text = p.Soyad;
            txtDepartman.Text = p.Departman;
            txtEmailPers.Text = p.Email;
            txtTelefonPers.Text = p.Telefon;
        }

        private void BtnPersEkle_Click(object sender, EventArgs e)
        {
            // Basit validasyon
            if (string.IsNullOrWhiteSpace(txtPersAd.Text) ||
                string.IsNullOrWhiteSpace(txtPersSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad alanlarını doldurun.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var p = new Personel
            {
                Ad = txtPersAd.Text.Trim(),
                Soyad = txtPersSoyad.Text.Trim(),
                Departman = txtDepartman.Text.Trim(),
                Email = txtEmailPers.Text.Trim(),
                Telefon = txtTelefonPers.Text.Trim()
            };

            db.Personeller.Add(p);
            db.SaveChanges();
            LoadPersoneller();
        }

        private void BtnPersGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null) return;

            int id = (int)dgvPersonel.CurrentRow.Cells["Id"].Value;
            var p = db.Personeller.Find(id);
            if (p == null) return;

            p.Ad = txtPersAd.Text.Trim();
            p.Soyad = txtPersSoyad.Text.Trim();
            p.Departman = txtDepartman.Text.Trim();
            p.Email = txtEmailPers.Text.Trim();
            p.Telefon = txtTelefonPers.Text.Trim();

            db.SaveChanges();
            LoadPersoneller();
        }

        private void BtnPersSil_Click(object sender, EventArgs e)
        {
            if (dgvPersonel.CurrentRow == null) return;

            int id = (int)dgvPersonel.CurrentRow.Cells["Id"].Value;
            var p = db.Personeller.Find(id);
            if (p == null) return;

            if (MessageBox.Show("Seçili personeli silmek istediğinize emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            db.Personeller.Remove(p);
            db.SaveChanges();
            LoadPersoneller();
        }
    }
}
