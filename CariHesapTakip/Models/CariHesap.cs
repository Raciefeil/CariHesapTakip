using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CariHesapTakip.Models
{
    public class CariHesap
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Musteri))]
        public int MusteriId { get; set; }

        [Required, MaxLength(50)]
        public string HesapKodu { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Bakiye { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual Musteri Musteri { get; set; }
        public virtual ICollection<CariHareket> Hareketler { get; set; }
    }
}
