using System.Data.Entity;
using CariHesapTakip.Models;

namespace CariHesapTakip.Data
{
    public class CariContext : DbContext
    {
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Sadece CariHesap.Bakiye kolonunu SQL'de decimal(18,2) olarak tanımla
            modelBuilder.Entity<CariHesap>()
                .Property(c => c.Bakiye)
                .HasColumnType("decimal")
                .HasPrecision(18, 2);

            // Sadece CariHareket.Tutar kolonunu SQL'de decimal(18,2) olarak tanımla
            modelBuilder.Entity<CariHareket>()
                .Property(h => h.Tutar)
                .HasColumnType("decimal")
                .HasPrecision(18, 2);
        }
    }
}
