using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PruebaTec02IJGZ.Models
{
    public class Estudiantes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100)]
        [Column(Order =2)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100)]
        [Column(Order = 3)]
        public string Apellidos { get; set; }

        [DataType(DataType.Date)]
        [Column(Order = 4)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime FechaMatricula { get; set; }

        [Column(Order = 1)]
        public byte[] Imagen { get; set; }

        [ForeignKey("CursosId")]
        public int CursosId { get; set; }
        public Cursos Cursos { get; set; }
    }
}
