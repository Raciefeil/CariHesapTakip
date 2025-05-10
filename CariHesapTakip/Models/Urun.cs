using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CariHesapTakip.Models
{
    public class Urun
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Ad { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal BirimFiyat { get; set; }

        [MaxLength(50)]
        public string Kategori { get; set; }

        public int StokMiktar { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<CariHareket> Hareketler { get; set; }
    }
}
