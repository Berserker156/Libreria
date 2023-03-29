using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;


namespace EL
{
    [Table("Formularios")]
    public class Formularios
    {
        [Key]
        public int IdFormulario { get; set; }

        [MaxLength(50)]
        [Required]
        public string Formulario { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        public int IdUsuarioRegistra { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        public int? IdUsuarioActualiza { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        private class KeyAttribute : Attribute
        {
        }
    }
}
