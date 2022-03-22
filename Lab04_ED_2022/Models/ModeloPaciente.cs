using System.ComponentModel.DataAnnotations;

namespace Lab04_ED_2022.Models
{
    public class ModeloPaciente
    {
//      Nombre para mostrar al momento de visualizar pacientes
        [Required]
        public string Nombres { get; set; }
//      false hombre verdadero mujer
        [Required]
        public bool Genero { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public string Especializacion { get; set; }
//      falso ambulancia verdadero asistido
        [Required]
        public bool Ingreso { get; set; }

        public int Prioridad { get; set; }

//      hora: 0000, 0010, 1400, 1350,
        [Required]
        public int Hora { get; set; }
   
    }
}
