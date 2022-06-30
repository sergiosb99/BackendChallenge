using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallenge.Models
{
    public class HistorialVehiculo
    {
        [Key]
        public virtual Vehiculo Vehiculo { get; set; }

        [Required]
        public string Ubicacion { get; set; }
    }
}
