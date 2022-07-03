using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallenge.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Conductor { get; set; }

        [Required]
        public string Ubicacion { get; set; }

        [Required]
        public virtual List<Pedido> Pedidos { get; set; }

        [Required]
        public virtual List<Historial> Historiales { get; set; }
    }
}
