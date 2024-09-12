using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public abstract class Entitet
    {
        [Key]
        public int? sifra { get; set; }
    }
}
