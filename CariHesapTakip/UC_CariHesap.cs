using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CariHesapTakip.Data;
using CariHesapTakip.Models;

namespace CariHesapTakip
{
    public partial class UC_CariHesap : UserControl
    {
        private CariContext db;

        public UC_CariHesap()
        {
            InitializeComponent();

            // Tasarım zamanında çalıştırılmasını engelle
            if (!DesignMode)
            {
                db = new CariContext();
                this.Load += UC_CariHesap_Load;
                dgvCari.SelectionChanged += dgvCari_SelectionChanged;
            }
        }

        private void UC_CariHesap_Load(object sender, EventArgs e)
        {
            LoadCustomersToComboBox();
            LoadCariHesaplar();
            ClearForm();
        }

        private void LoadCustomersToComboBox()
        {
            var customers = db.Musteriler.ToList();
            cmbMusteri.DataSource = customers;
            cmbMusteri.DisplayMember = "Ad";
            cmbMusteri.ValueMember = "Id";
            cmbMusteri.SelectedIndex = -1;
        }

        private void LoadCariHesaplar()
        {
            var list = db.CariHesaplar
                .Include(c => c.Musteri)
                .Select(c => new
                {
                    c.Id,
                    Musteri = c.Musteri.Ad + " " + c.Musteri.Soyad,
                    c.HesapKodu,
                    c.Bakiye
                })
                .ToList();

            dgvCari.DataSource = list;
            if (dgvCari.Columns["Id"] != null)
                dgvCari.Columns["Id"].Visible = false;
        }

        private void dgvCari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCari.CurrentRow == null) return;

            int id = (int)dgvCari.CurrentRow.Cells["Id"].Value;
            var ch = db.CariHesaplar.Find(id);
            if (ch == null) return;

            cmbMusteri.SelectedValue = ch.MusteriId;
            txtHesapKodu.Text = ch.HesapKodu;
            txtBakiye.Text = ch.Bakiye.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedIndex < 0 || string.IsNullOrWhiteSpace(txtHesapKodu.Text))
            {
                MessageBox.Show("Lütfen müşteri ve hesap kodu girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ch = new CariHesap
            {
                MusteriId = (int)cmbMusteri.SelectedValue,
                HesapKodu = txtHesapKodu.Text.Trim(),
                Bakiye = decimal.TryParse(txtBakiye.Text, out var b) ? b : 0
            };

            db.CariHesaplar.Add(ch);
            db.SaveChanges();
            LoadCariHesaplar();
            ClearForm();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvCari.CurrentRow == null)
            {
                MessageBox.Show("Güncellemek için bir kayıt seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvCari.CurrentRow.Cells["Id"].Value;
            var ch = db.CariHesaplar.Find(id);
            if (ch == null) return;

            if (cmbMusteri.SelectedIndex < 0 || string.IsNullOrWhiteSpace(txtHesapKodu.Text))
            {
                MessageBox.Show("Lütfen müşteri ve hesap kodu girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ch.MusteriId = (int)cmbMusteri.SelectedValue;
            ch.HesapKodu = txtHesapKodu.Text.Trim();
            ch.Bakiye = decimal.TryParse(txtBakiye.Text, out var b2) ? b2 : ch.Bakiye;

            db.SaveChanges();
            LoadCariHesaplar();
            ClearForm();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvCari.CurrentRow == null)
            {
                MessageBox.Show("Silmek için bir kayıt seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvCari.CurrentRow.Cells["Id"].Value;
            var ch = db.CariHesaplar.Find(id);
            if (ch == null) return;

            if (MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?", "Silme Onayı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            db.CariHesaplar.Remove(ch);
            db.SaveChanges();
            LoadCariHesaplar();
            ClearForm();
        }

        private void ClearForm()
        {
            cmbMusteri.SelectedIndex = -1;
            txtHesapKodu.Clear();
            txtBakiye.Clear();
            dgvCari.ClearSelection();
        }
    }
}
