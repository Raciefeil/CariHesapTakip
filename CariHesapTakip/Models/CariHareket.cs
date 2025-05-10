using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CariHesapTakip.Models
{
    public class CariHareket
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(CariHesap))]
        public int CariHesapId { get; set; }

        [ForeignKey(nameof(Personel))]
        public int PersonelId { get; set; }

        [ForeignKey(nameof(Urun))]
        public int UrunId { get; set; }

        [ForeignKey(nameof(OdemeTipi))]
        public int OdemeTipiId { get; set; }

        public DateTime Tarih { get; set; } = DateTime.Now;

        public int Miktar { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Tutar { get; set; }

        [MaxLength(200)]
        public string Aciklama { get; set; }

        public virtual CariHesap CariHesap { get; set; }
        public virtual Personel Personel { get; set; }
        public virtual Urun Urun { get; set; }
        public virtual OdemeTipi OdemeTipi { get; set; }
    }
}
