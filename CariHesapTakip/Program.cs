using System;
using System.Windows.Forms;

namespace CariHesapTakip
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Görsel stilleri etkinleştir
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Uygulamayı önce LoginForm ile başlat
            Application.Run(new LoginForm());
        }
    }
}
