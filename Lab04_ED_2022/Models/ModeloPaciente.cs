using System;
using System.ComponentModel.DataAnnotations;
using Lab04_ED_2022.Helpers;

namespace Lab04_ED_2022.Models
{
    public class ModeloPaciente
    {
//      Nombre para mostrar al momento de visualizar pacientes
        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }
        //      false hombre verdadero mujer
        [Required]
        public string Genero { get; set; }
        
        public int Edad { get; set; }
        [Required]
        public string Especializacion { get; set; }
//      falso ambulancia verdadero asistido
        [Required]
        public string Ingreso { get; set; }

        public int Prioridad { get; set; }

//      hora: 0000, 0010, 1400, 1350,
        [Required]
        public int Hora { get; set; }

        [Required]
        public DateTime FechaDeNacimiento { get; set; }

        public static void Save(ModeloPaciente paciente)
        {
            
            Data.Instance.miHeap.Insertar(paciente);
        }

        
        public TimeSpan SetEdad(ModeloPaciente a, ModeloPaciente b)
        {
            TimeSpan edad = a.FechaDeNacimiento - b.FechaDeNacimiento;
            return edad;
        }

    }
}
