using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;        // NuGet → FontAwesome.Sharp
using CariHesapTakip.UI.Controls;  // UC_Musteri, UC_CariHesap, vb.

namespace CariHesapTakip
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Yan menüyü doldur
            InitializeSidebar();

            // Uygulama başladığında Müşteri modülünü göster
            LoadControl(new UC_Musteri());
        }

        private void InitializeSidebar()
        {
            // Modül tanımları: buton adı, buton metni, ikon, yüklenecek kontrol
            var modules = new[]
            {
                new { Name="btnMusteri",    Text="Müşteriler",   Icon=IconChar.Users,            Control=(UserControl)new UC_Musteri() },
                new { Name="btnCariKart",   Text="Cari Kartlar",  Icon=IconChar.CreditCard,       Control=(UserControl)new UC_CariHesap() },
                new { Name="btnHareket",    Text="Hareketler",    Icon=IconChar.ExchangeAlt,      Control=(UserControl)new UC_CariHareket() },
                new { Name="btnUrun",       Text="Ürünler",       Icon=IconChar.Box,              Control=(UserControl)new UC_Urun() },
                new { Name="btnPersonel",   Text="Personel",      Icon=IconChar.UserTie,          Control=(UserControl)new UC_Personel() },
                new { Name="btnOdemeTipi",  Text="Ödeme Tipi",    Icon=IconChar.MoneyCheckAlt,    Control=(UserControl)new UC_OdemeTipi() },
                new { Name="btnRapor",      Text="Raporlar",      Icon=IconChar.ChartLine,        Control=(UserControl)new UC_Rapor() }
            };

            // Butonları sondan başa ekle ki sırayla görünsün
            for (int i = modules.Length - 1; i >= 0; i--)
            {
                var mod = modules[i];
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
                    Padding = new Padding(10, 0, 0, 0),
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += (s, e) => LoadControl(mod.Control);

                panelSidebar.Controls.Add(btn);
            }
        }

        // panelContent’e istediğiniz UserControl’ü yükleyen metot
        private void LoadControl(UserControl uc)
        {
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
        }
    }
}
