using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallenge.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual string Descripcion { get; set; }

        [Required]
        public virtual Cliente Cliente { get; set; }

        //[Required]
        //public int Id_Cliente { get; set; }

        [Required]
        public virtual Vehiculo Vehiculo { get; set; }

        //[Required]
        //public int Id_Vehiculo { get; set; }

    }
}
