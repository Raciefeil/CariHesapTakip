using System;
using System.Linq;
using System.Windows.Forms;
using CariHesapTakip.Data;
using CariHesapTakip.Helpers;
using CariHesapTakip.Models;

namespace CariHesapTakip
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // 0. Veritabanına default kullanıcı ekle (sadece ilk sefer veya tablo boşsa)
            using (var db = new CariContext())
            {
                if (!db.Users.Any(u => u.Username == "admin"))
                {
                    db.Users.Add(new User
                    {
                        Username = "admin",
                        PasswordHash = HashHelper.ComputeSha256Hash("admin123")
                    });
                    db.SaveChanges();
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Önce LoginForm’u modal göster
            var loginForm = new LoginForm();
            var dr = loginForm.ShowDialog();
            if (dr != DialogResult.OK)
                return;   // iptal veya hata ise uygulama kapansın

            // 2. Giriş başarılıysa ana ekrana geç
            Application.Run(new MainForm());
        }
    }
}
