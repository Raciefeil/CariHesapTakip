using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using CariHesapTakip.Models;

namespace CariHesapTakip.Data
{
    public class CariContext : DbContext
    {
        // App.config içindeki connectionStrings bölümünde
        // <add name="ApplicationDbContext" … /> olarak tanımladığınız ismi
        // aşağıdaki base çağrısına aynen yazdık:
        public CariContext()
            : base("name=ApplicationDbContext")
        {
        }

        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<OdemeTipi> OdemeTipleri { get; set; }
        public DbSet<CariHesap> CariHesaplar { get; set; }
        public DbSet<CariHareket> Hareketler { get; set; }
    }
}
