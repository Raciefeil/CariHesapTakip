using System.ComponentModel.DataAnnotations;

namespace CariHesapTakip.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(200)]
        public string PasswordHash { get; set; }
    }
}
