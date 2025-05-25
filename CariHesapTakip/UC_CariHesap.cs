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

        /// <summary>
        /// DataGridView'i veritabanındaki cari kartlarla doldurur.
        /// </summary>
        private void LoadCariKartlar()
        {
            // Burada 'dgvCari' sizin DataGridView'inizin Name'i
            // ve 'cmbMusteri', 'txtHesapKodu', 'txtBakiye' kontrollerinin
            // aynı isimde olduğundan emin olun.

            var liste = db.CariHesaplar
                .Include(c => c.Musteri)      // using System.Data.Entity;
                .Select(c => new
                {
                    c.Id,
                    Musteri = c.Musteri.Ad + " " + c.Musteri.Soyad,
                    c.HesapKodu,
                    c.Bakiye
                })
                .ToList();

            dgvCari.DataSource = liste;

            // Id sütununu gizle (isteğe bağlı)
            if (dgvCari.Columns["Id"] != null)
                dgvCari.Columns["Id"].Visible = false;
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

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHesapKodu.Text))
            {
                MessageBox.Show("Hesap kodunu girin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yeni = new CariHesap
            {
                MusteriId = (int)cmbMusteri.SelectedValue,
                HesapKodu = txtHesapKodu.Text.Trim(),
                Bakiye = decimal.TryParse(txtBakiye.Text, out var b) ? b : 0m
            };

            db.CariHesaplar.Add(yeni);
            db.SaveChanges();
            LoadCariKartlar();
            ClearForm();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {

            if (dgvCari.CurrentRow == null)
            {
                MessageBox.Show("Güncellemek için bir kayıt seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvCari.CurrentRow.Cells["Id"].Value;
            var c = db.CariHesaplar.Find(id);
            if (c == null) return;

            c.MusteriId = (int)cmbMusteri.SelectedValue;
            c.HesapKodu = txtHesapKodu.Text.Trim();
            c.Bakiye = decimal.TryParse(txtBakiye.Text, out var b2) ? b2 : c.Bakiye;

            db.SaveChanges();
            LoadCariKartlar();
            ClearForm();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (dgvCari.CurrentRow == null)
            {
                MessageBox.Show("Silmek için bir kayıt seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvCari.CurrentRow.Cells["Id"].Value;
            var c = db.CariHesaplar.Find(id);
            if (c == null) return;

            if (MessageBox.Show("Seçili cari kartı silmek istediğinize emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            db.CariHesaplar.Remove(c);
            db.SaveChanges();
            LoadCariKartlar();
            ClearForm();
        }
    }
}
