using System.ComponentModel.DataAnnotations;
namespace LO1P02_2020GM606.Models
{
    public class motoristas
    {
        [Key]
        public int motoristaId { get; set; }
        public String? nombreMotorista { get; set; }
    }
}
