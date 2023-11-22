using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace JeanLuis_AP1_P2.Model
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string? Nombres { get; set; }
    }
}