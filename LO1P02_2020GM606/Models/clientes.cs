using System.ComponentModel.DataAnnotations;
namespace LO1P02_2020GM606.Models
{
    public class clientes
    {
        [Key]
        public int clienteId { get; set; }
        public String ? nombreCliente { get; set; }
        public String ? direccion { get; set; }

    }
}
