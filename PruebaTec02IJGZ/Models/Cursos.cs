using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PruebaTec02IJGZ.Models
{
    public class Cursos
    {
        // Definición de la entidad Carrera

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime FechaInicio { get; set; }

        public ICollection<Estudiantes> Estudiantes { get; set; }
    }
}
