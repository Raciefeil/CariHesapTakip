using System;
using System.Windows.Forms;

namespace CariHesapTakip
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Uygulamayı MainForm ile başlatıyor.
            Application.Run(new MainForm());
        }
    }
}
