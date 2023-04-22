using System.ComponentModel.DataAnnotations;
namespace LO1P02_2020GM606.Models
{
    public class platos
    {
        [Key]
        public int platoId { get; set; }
        public String? nombrePlato { get; set; }
        public decimal precio { get; set; }
    }
}
