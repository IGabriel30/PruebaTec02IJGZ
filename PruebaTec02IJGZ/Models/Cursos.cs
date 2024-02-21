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

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }


        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

       
    }
}
