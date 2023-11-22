using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace JeanLuis_AP1_P2.Model
{
    public class Ventas
    {
         [Key]
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public double Monto { get; set; }
        public double Balance { get; set; }
    }
}