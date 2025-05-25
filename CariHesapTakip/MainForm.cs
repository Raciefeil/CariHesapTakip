using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;           // IconButton, IconChar
using CariHesapTakip.UI.Controls;  // UC_Musteri, UC_CariHesap, UC_Dashboard, vs.

namespace CariHesapTakip
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Uygulamayı tam ekran başlatmak isterseniz
            this.WindowState = FormWindowState.Maximized;

            // Yan menüyü oluştur
            InitializeSidebar();

            // Uygulama açılışında varsayılan kontrol olarak Dashboard veya Müşteri yükleyebilirsiniz
            LoadControl(new UC_Musteri());
        }

        /// <summary>
        /// panelSidebar içine modül butonlarını ekler.
        /// </summary>
        private void InitializeSidebar()
        {
            // Mevcut kontrolleri temizle
            panelSidebar.Controls.Clear();

            // Her modül için Name, Text, Icon ve yüklenecek UserControl
            var modules = new[]
            {
                new { Name="btnDashboard",   Text="Dashboard",    Icon=IconChar.Home,            Control=(UserControl)new UC_Dashboard() },
                new { Name="btnMusteri",     Text="Müşteriler",   Icon=IconChar.Users,           Control=(UserControl)new UC_Musteri() },
                new { Name="btnCariKart",    Text="Cari Kartlar", Icon=IconChar.CreditCard,      Control=(UserControl)new UC_CariHesap() },
                new { Name="btnHareket",     Text="Hareketler",   Icon=IconChar.ExchangeAlt,     Control=(UserControl)new UC_CariHareket() },
                new { Name="btnUrun",        Text="Ürünler",      Icon=IconChar.Box,             Control=(UserControl)new UC_Urun() },
                new { Name="btnPersonel",    Text="Personel",     Icon=IconChar.UserTie,         Control=(UserControl)new UC_Personel() },
                new { Name="btnOdemeTipi",   Text="Ödeme Tipi",   Icon=IconChar.MoneyCheckAlt,   Control=(UserControl)new UC_OdemeTipi() },
                new { Name="btnRapor",       Text="Raporlar",     Icon=IconChar.ChartLine,       Control=(UserControl)new UC_Rapor() }
            };

            // Butonları sırayla ekle (her yeni buton en üste yerleşsin)
            foreach (var mod in modules)
            {
                var btn = new IconButton
                {
                    Name = mod.Name,
                    Text = "  " + mod.Text,
                    IconChar = mod.Icon,
                    IconColor = Color.White,
                    IconSize = 24,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Top,
                    Height = 50,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    Padding = new Padding(10, 0, 0, 0)
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += (s, e) => LoadControl(mod.Control);

                panelSidebar.Controls.Add(btn);
                panelSidebar.Controls.SetChildIndex(btn, 0);
            }
        }

        /// <summary>
        /// panelContent içine verilen UserControl'ü yükler.
        /// </summary>
        /// <param name="uc">Yüklenecek UserControl</param>
        private void LoadControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }
    }
}
