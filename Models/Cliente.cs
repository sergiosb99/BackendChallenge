using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendChallenge.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Nombre { get; set; }
    }
}
