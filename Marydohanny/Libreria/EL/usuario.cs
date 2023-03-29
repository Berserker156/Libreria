using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    [Table("Usuarios")]
    public class usuario
    {
        [Key]
        public int IdUsuario { set; get; }

        [MaxLength(200)]
        [Required]
        public string NombreCompleto { set; get; }

        [MaxLength(200)]
        [Required]
        public string Correo { set; get; }

        [MaxLength(50)]
        [Required]
        public string UserName { set; get; }

        [Required]
        public Byte[] Password { get; set; }

        [Required]
        public bool Bloqueado { get; set; }

        [Required]
        public byte IntentosFallidos { get; set; }


        [Required]
        public int IdRol { get; set; }

        [Required]
        public bool Activo { get; set; }

        [Required]
        public int IdUsuarioRegistra { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        public int? IdUsuarioActualiza { get; set; }

        public DateTime? FechaActualizacion { get; set; }
    }
}
