using System;
using Lab04_ED_2022.Models;

namespace Lab04_ED_2022.Delegados
{
    public delegate void Prioridad<T>(T a);
    public delegate int Prioridad2<T>(T a);
    public delegate int Comparar<T>(T a, T b);
    public delegate int CompararNodos<T>(T a, T b);

    public class Delegados
    {
        //Heapify!
        public static int HeapifyDelegate(ModeloPaciente a, ModeloPaciente b) 
        {
            if (a.Prioridad != b.Prioridad)
            {
                return a.Prioridad > b.Prioridad ? 1 : -1;
            }
            else
            {
                ExcepcionHora(a, b);
                return HeapifyDelegate(a, b);
            }
        }

        public static int CompararNodos(ModeloPaciente a, ModeloPaciente b)
        {
            return a == b ? 0 : 1; 
        }
        public static int PrioridadVacia(ModeloPaciente a)
        {
            return a.Prioridad == 0 ? 0 : 1;
        }

        public static void SetPrioridad(ModeloPaciente paciente)
        {
            //suma prioridad de acuerdo al genero

            //paciente.Género == false ? paciente.Prioridad += 3 : paciente.Prioridad += 5;
            if (paciente.Género == true)
            {
                paciente.Prioridad += 5;
            }
            else
                paciente.Prioridad += 3;

            if (paciente.Ingreso == true)
            {
                paciente.Prioridad += 3;
            }
            else
                paciente.Prioridad += 5;

            //          suma prioridad de acuerdo a la edad 
            paciente.Prioridad += (PrioridadEdad(paciente));

            //          suma prioridad de acuerdo a la especializacion
            PrioridadEspecializacion(paciente);
        }

        //70  +: +10 
        //50-69: +8  
        //18-49: +3  
        //6 -17: +5  
        //0 - 5: +8  

        public static int PrioridadEdad(ModeloPaciente paciente)
        {
            paciente.Edad = CalcularEdad(paciente);

            if (paciente.Edad >= 0 && paciente.Edad <= 5)
            {
                return 8;
            }

            if (paciente.Edad >= 6 && paciente.Edad <= 17)
            {
                return 5;
            }

            if (paciente.Edad >= 18 && paciente.Edad <= 49)
            {
                return 3;
            }

            if (paciente.Edad >= 50 && paciente.Edad <= 69)
            {
                return 8;
            }

            return 10;
        }

        //cardio:     +10 (1)
        //neumo:      +8  (2)
        //traumaexp:  +8  (3)
        //gine:       +5  (4)
        //traumaint:  +3  (5)

        public static void PrioridadEspecializacion(ModeloPaciente paciente)
        {
            switch (paciente.Especializacion)
            {
                case 1:
                    paciente.Prioridad += 10;
                    break;
                case 2:
                    paciente.Prioridad += 8;
                    break;
                case 3:
                    paciente.Prioridad += 8;
                    break;
                case 4:
                    paciente.Prioridad += 5;
                    break;
                case 5:
                    paciente.Prioridad += 3;
                    break;
            }
        }

        public static int CalcularEdad(ModeloPaciente paciente)
        {
            DateTime acutal = DateTime.Now;
            int edad = new DateTime(DateTime.Now.Subtract(paciente.FechaDeNacimiento).Ticks).Year - 1;

            return edad;
        }

        public static void ExcepcionHora(ModeloPaciente a, ModeloPaciente b)
        {
            if (a.Hora > b.Hora)
            {
                b.Prioridad += 1;
            }
            else
            {
                a.Prioridad += 1;
            }
        }
    }
}
