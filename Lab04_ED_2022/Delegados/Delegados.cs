using System;
using Lab04_ED_2022.Models;

namespace Lab04_ED_2022.Delegados
{
    public delegate void Prioridad<T>(T a);
    public delegate int Comparar<T>(T a, T b);

    public class Delegados
    {

        public static int Heapify(ModeloPaciente a, ModeloPaciente b) //arreglar mayúscula
        {
            return a.Prioridad > b.Prioridad ? 1 : -1;
        }
        public static void setPrioridad(ModeloPaciente paciente)
        {
            //          suma prioridad de acuerdo al genero
            if (paciente.Genero.CompareTo("hombre") == 0)//radiobutton
            {
                //              hombre                
                paciente.Prioridad += 3;
            }
            else if (paciente.Genero.CompareTo("mujer") == 0)
            {
                //              mujer                
                paciente.Prioridad += 5;
            }

            if (paciente.Ingreso.CompareTo("ambulancia") == 0)
            {
                //              ingreso ambulancia                 
                paciente.Prioridad += 5;
            }
            else if (paciente.Ingreso.CompareTo("asistido") == 0)
            {
                //              ingreso asistido
                paciente.Prioridad += 3;
            }

            //          suma prioridad de acuerdo a la edad 
            switch (prioridadEdad(paciente))
            {
                case 1:
                    paciente.Prioridad += 8;
                    break;

                case 2:
                    paciente.Prioridad += 5;
                    break;

                case 3:
                    paciente.Prioridad += 3;
                    break;

                case 4:
                    paciente.Prioridad += 8;
                    break;

                case 5:
                    paciente.Prioridad += 10;
                    break;
            }
            //          suma prioridad de acuerdo a la especializacion
            switch (prioridadEspecializacion(paciente))
            {
                case 1:
                    paciente.Prioridad += 3;
                    break;
                case 2:
                    paciente.Prioridad += 5;
                    break;
                case 3:
                    paciente.Prioridad += 8;
                    break;
                case 4:
                    paciente.Prioridad += 8;
                    break;
                case 5:
                    paciente.Prioridad += 10;
                    break;
                case 6:
                    paciente.Prioridad += 0;
                    break;
            }

        }

        //70  +: +10 (5)
        //50-69: +8  (4)
        //18-49: +3  (3)
        //6 -17: +5  (2)
        //0 - 5: +8  (1)

        public static int prioridadEdad(ModeloPaciente paciente)
        {
            if (paciente.Edad >= 0 && paciente.Edad <= 5)
            {
                return 1;
            }

            if (paciente.Edad >= 6 && paciente.Edad <= 17)
            {
                return 2;
            }

            if (paciente.Edad >= 18 && paciente.Edad <= 49)
            {
                return 3;
            }

            if (paciente.Edad >= 50 && paciente.Edad <= 69)
            {
                return 4;
            }

            return 5;
        }

        //cardio:     +10 (5)
        //neumo:      +8  (4)
        //traumaexp:  +8  (3) 
        //gine:       +5  (2)
        //traumaint:  +3  (1)

        public static int prioridadEspecializacion(ModeloPaciente paciente)
        {
            if (paciente.Especializacion.CompareTo("cardio") == 0)//combobox / select-option
            {
                return 5;
            }
            else if (paciente.Especializacion.CompareTo("neumo") == 0)
            {
                return 4;
            }
            else if (paciente.Especializacion.CompareTo("traumaexp") == 0)
            {
                return 3;
            }
            else if (paciente.Especializacion.CompareTo("gine") == 0)
            {
                return 2;
            }
            else if (paciente.Especializacion.CompareTo("traumaint") == 0)
            {
                return 1;
            }
            else
            {
                return 6;
            }
        }

        public static void excepcionHora(ModeloPaciente a, ModeloPaciente b)
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
