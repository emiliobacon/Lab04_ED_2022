using System.ComponentModel.DataAnnotations;

namespace Lab04_ED_2022.Models
{
    public class ModeloPaciente
    {
//      Nombre para mostrar al momento de visualizar pacientes
        [Required]
        public string Nombres { get; set; }
//      0 hombre 1 mujer
        [Required]
        public bool Genero { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public string Especializacion { get; set; }
//      0 ambulancia 1 asistido
        [Required]
        public bool Ingreso { get; set; }
   
    }
}
