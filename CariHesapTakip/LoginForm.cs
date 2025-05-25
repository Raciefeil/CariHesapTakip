using System;
using System.Linq;
using System.Windows.Forms;
using CariHesapTakip.Data;
using CariHesapTakip.Helpers;
using CariHesapTakip.Models;

namespace CariHesapTakip
{
    public partial class LoginForm : Form
    {
        private readonly CariContext db = new CariContext();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Form açıldığında çalışacak kodlar (isteğe bağlı)
            txtKullanıcıAdı.Focus();   // örneğin kullanıcı adı kutusuna odaklan
        }

        public LoginForm()
        {
            InitializeComponent();

            // Event handler'ları bağla
            btnGiriş.Click += BtnLogin_Click;
            btnİptal.Click += (s, e) => Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var username = txtKullanıcıAdı.Text.Trim();
            var password = txtParola.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show(
                    "Lütfen kullanıcı adı ve parola girin.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Kullanıcıyı veritabanından çek
            var user = db.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                MessageBox.Show(
                    "Kullanıcı bulunamadı.",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Parola hash'ini karşılaştır
            var enteredHash = HashHelper.ComputeSha256Hash(password);
            if (user.PasswordHash != enteredHash)
            {
                MessageBox.Show(
                    "Parola hatalı.",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Başarılı giriş: MainForm'u aç
            this.Hide();
            using (var main = new MainForm())
            {
                main.ShowDialog();
            }
            this.Close();
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            var username = txtKullanıcıAdı.Text.Trim();
            var password = txtParola.Text;

            // Validasyon
            if (username == "" || password == "")
            {
                MessageBox.Show("Kullanıcı adı ve parola girin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = db.Users.FirstOrDefault(u => u.Username == username);
            if (user == null ||
                user.PasswordHash != HashHelper.ComputeSha256Hash(password))
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı.", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Giriş başarılı → DialogResult.OK ile formu kapat
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
