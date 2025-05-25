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
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // CariHesap tablosundaki Bakiye
            modelBuilder.Entity<CariHesap>()
                .Property(c => c.Bakiye)
                .HasColumnType("decimal")
                .HasPrecision(18, 2);

            // CariHareket tablosundaki Tutar
            modelBuilder.Entity<CariHareket>()
                .Property(h => h.Tutar)
                .HasColumnType("decimal")
                .HasPrecision(18, 2);

            // URUN tablosundaki BirimFiyat
            modelBuilder.Entity<Urun>()
                .Property(u => u.BirimFiyat)
                .HasColumnType("decimal")
                .HasPrecision(18, 2);
        }
    }
}
