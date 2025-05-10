using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CariHesapTakip.Models
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Ad { get; set; }

        [Required, MaxLength(100)]
        public string Soyad { get; set; }

        [MaxLength(50)]
        public string Departman { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Telefon { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<CariHareket> Hareketler { get; set; }
    }
}
