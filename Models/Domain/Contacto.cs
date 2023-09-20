using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionCrud.Models.Domain
{
    public class Contacto
    {
        [Key]
        public int? id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string? Nombre { get; set; }
        
        [Required(ErrorMessage = "El Teléfono es requerido.")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El Celular es requerido.")]
        public string? Celular { get; set; }

        public DateTime FechaCreacion { get; set; }
        

    }
}