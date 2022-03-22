using Lab04_ED_2022.Models;

namespace Lab04_ED_2022.Delegados
{
    public delegate int Prioridad<T>(T a);
    public delegate int Comparar<T>(T a, T b);

    public class Delegados
    {
        public static int setPrioridad(ModeloPaciente paciente)
        {
            int prioridad = 0;

            //          suma prioridad de acuerdo al genero
            if (paciente.Genero == false)
            {
                //              hombre                
                prioridad += 3;
            }
            else
                //              mujer                
                prioridad += 5;

            if (paciente.Ingreso == false)
            {
                //              ingreso ambulancia                 
                prioridad += 5;
            }
            else
                //              ingreso asistido
                prioridad += 3;

            //          suma prioridad de acuerdo a la edad 
            switch (prioridadEdad(paciente))
            {
                case 1:
                    prioridad += 8;
                    break;

                case 2:
                    prioridad += 5;
                    break;

                case 3:
                    prioridad += 3;
                    break;

                case 4:
                    prioridad += 8;
                    break;

                case 5:
                    prioridad += 10;
                    break;
            }
            //          suma prioridad de acuerdo a la especializacion
            switch (prioridadEspecializacion(paciente))
            {
                case 1:
                    prioridad += 3;
                    break;
                case 2:
                    prioridad += 5;
                    break;
                case 3:
                    prioridad += 8;
                    break;
                case 4:
                    prioridad += 8;
                    break;
                case 5:
                    prioridad += 10;
                    break;
                case 6:
                    prioridad += 0;
                    break;
            }
            //          regresa el valor que sera asignado como prioridad
            return prioridad;
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
            else if (paciente.Edad >= 6 && paciente.Edad <= 17)
            {
                return 2;
            }
            else if (paciente.Edad >= 18 && paciente.Edad <= 49)
            {
                return 3;
            }
            else if (paciente.Edad >= 50 && paciente.Edad <= 69)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        //cardio:     +10 (5)
        //neumo:      +8  (4)
        //traumaexp:  +8  (3) 
        //gine:       +5  (2)
        //traumaint:  +3  (1)

        public static int prioridadEspecializacion(ModeloPaciente paciente)
        {
            if (paciente.Especializacion.CompareTo("cardio") == 0)
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

        

    }
}
