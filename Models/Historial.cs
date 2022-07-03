using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallenge.Models
{
    public class Historial
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int VehiculoId { get; set; }

        [Required]
        public string Ubicacion { get; set; }

        [Required]
        public Vehiculo Vehiculo { get; set; }
    }
}
