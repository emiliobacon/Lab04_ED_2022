using System;
using System.ComponentModel.DataAnnotations;
using Lab04_ED_2022.Helpers;

namespace Lab04_ED_2022.Models
{
    public class ModeloPaciente
    {
        //Nombre para mostrar al momento de visualizar pacientes
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        //false hombre, true mujer
        [Required]
        public bool Género { get; set; }
       
        public int Edad { get; set; }
        [Required]
        public int Especializacion { get; set; }
//      falso ambulancia true asistido
        [Required]
        public bool Ingreso { get; set; }
        public int Prioridad { get; set; }


        [Required]
        public TimeSpan Hora { get; set; }

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
