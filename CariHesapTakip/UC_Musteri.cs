using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using CariHesapTakip.Data;    // DbContext’in olduğu namespace
using CariHesapTakip.Models;  // Musteri modelinin olduğu namespace

namespace CariHesapTakip
{
    public partial class UC_Musteri : UserControl
    {
        // Veritabanı bağlantısı için context
        private readonly CariContext db = new CariContext();

        public UC_Musteri()
        {
            InitializeComponent();

            // Load event’ini bağla
            this.Load += UC_Musteri_Load;
            // DataGridView seçim değişikliğini bağla
            dgvMusteri.SelectionChanged += dgvMusteri_SelectionChanged;
        }

        private void UC_Musteri_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde verileri getir
            LoadCustomers();
            // Tabla boş seçili gelecekse ClearSelection yap
            dgvMusteri.ClearSelection();
        }

        // 1) DataGridView’e müşteri listesini yükler
        private void LoadCustomers()
        {
            var liste = db.Musteriler
                .Select(m => new
                {
                    m.Id,
                    m.Ad,
                    m.Soyad,
                    m.Telefon,
                    m.Email,
                    m.VergiNo
                })
                .ToList();

            dgvMusteri.DataSource = liste;

            // Id sütununu gizlemek isterseniz:
            if (dgvMusteri.Columns["Id"] != null)
                dgvMusteri.Columns["Id"].Visible = false;
        }

        // 2) Seçilen satırı TextBox’lara yansıtır
        private void dgvMusteri_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMusteri.CurrentRow == null) return;

            int id = (int)dgvMusteri.CurrentRow.Cells["Id"].Value;
            var m = db.Musteriler.Find(id);
            if (m == null) return;

            txtAd.Text = m.Ad;
            txtSoyad.Text = m.Soyad;
            txtTelefon.Text = m.Telefon;
            txtEmail.Text = m.Email;
            txtVergiNo.Text = m.VergiNo;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad alanlarını doldurun.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var musteri = new Musteri
            {
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                Telefon = txtTelefon.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                VergiNo = txtVergiNo.Text.Trim()
            };

            db.Musteriler.Add(musteri);
            db.SaveChanges();

            LoadCustomers();
            ClearForm();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteri.CurrentRow == null)
            {
                MessageBox.Show("Güncellemek için bir kayıt seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvMusteri.CurrentRow.Cells["Id"].Value;
            var musteri = db.Musteriler.Find(id);
            if (musteri == null) return;

            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad alanlarını doldurun.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            musteri.Ad = txtAd.Text.Trim();
            musteri.Soyad = txtSoyad.Text.Trim();
            musteri.Telefon = txtTelefon.Text.Trim();
            musteri.Email = txtEmail.Text.Trim();
            musteri.VergiNo = txtVergiNo.Text.Trim();

            db.SaveChanges();

            LoadCustomers();
            ClearForm();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteri.CurrentRow == null)
            {
                MessageBox.Show("Silmek için bir kayıt seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvMusteri.CurrentRow.Cells["Id"].Value;
            var musteri = db.Musteriler.Find(id);
            if (musteri == null) return;

            var dr = MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?",
                                      "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            db.Musteriler.Remove(musteri);
            db.SaveChanges();

            LoadCustomers();
            ClearForm();
        }

        // 3) Formu temizleyen yardımcı metot
        private void ClearForm()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtVergiNo.Clear();
            dgvMusteri.ClearSelection();
        }

        private void dgvMusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            // Seçili satır yoksa uyarı
            if (dgvMusteri.CurrentRow == null)
            {
                MessageBox.Show("Silmek için bir kayıt seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Id’yi al, silme onayı, sil ve yeniden yükle
            int id = (int)dgvMusteri.CurrentRow.Cells["Id"].Value;
            var m = db.Musteriler.Find(id);
            if (m == null) return;

            if (MessageBox.Show("Seçili kaydı silmek istediğinize emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                != DialogResult.Yes) return;

            db.Musteriler.Remove(m);
            db.SaveChanges();
            LoadCustomers();
            ClearForm();
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            // Seçili satır yoksa uyar
            if (dgvMusteri.CurrentRow == null)
            {
                MessageBox.Show("Güncellemek için bir kayıt seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvMusteri.CurrentRow.Cells["Id"].Value;
            var m = db.Musteriler.Find(id);
            if (m == null) return;

            // Validasyon
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad alanlarını doldurun.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Alanları güncelle
            m.Ad = txtAd.Text.Trim();
            m.Soyad = txtSoyad.Text.Trim();
            m.Telefon = txtTelefon.Text.Trim();
            m.Email = txtEmail.Text.Trim();
            m.VergiNo = txtVergiNo.Text.Trim();

            db.SaveChanges();

            LoadCustomers();
            ClearForm();
        }
    }
}
