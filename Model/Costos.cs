using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JeanLuis_AP1_P2.Model
{
    public class Costos
    {
         [Key]
          public int CostoId { get; set; }
        public int ClienteId { get; set; }
        public string? Nombres { get; set; }
          public DateTime Fecha { get; set; }
           [ForeignKey("CostoId")]
       
        public virtual List<Costosdetalle> Costosdetalles {get; set;} = new List<Costosdetalle>();
        
    }
}