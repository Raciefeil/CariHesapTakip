using System;
using System.Windows.Forms;
using CariHesapTakip;  // UC_Musteri’nin namespace’i

namespace CariHesapTakip
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1) UC_Musteri'yi barındıracak ana formu oluştur
            var anaForm = new Form
            {
                Text = "Müşteri Yönetimi",
                StartPosition = FormStartPosition.CenterScreen,
                WindowState = FormWindowState.Maximized
            };

            // 2) UC_Musteri kontrolünü oluşturup formun tamamını kaplayacak şekilde ekle
            var musteriControl = new UC_Musteri
            {
                Dock = DockStyle.Fill
            };
            anaForm.Controls.Add(musteriControl);

            // 3) Uygulamayı bu form ile başlat
            Application.Run(anaForm);
        }
    }
}
