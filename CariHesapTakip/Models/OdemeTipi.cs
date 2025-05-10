using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CariHesapTakip.Models
{
    public class OdemeTipi
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string TipAdi { get; set; }

        [MaxLength(200)]
        public string Aciklama { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<CariHareket> Hareketler { get; set; }
    }
}
