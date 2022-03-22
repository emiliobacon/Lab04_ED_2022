using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04_ED_2022.Estructura_de_Datos
{
    public class Nodo<T>
    {
        public T Data;
        public int Prioridad;

        public Nodo<T> Izquierda;
        public Nodo<T> Derecha;
        public Nodo<T> Padre;

//      constructor de pioridad para el nodo
        public Nodo(int prioridad)
        {
            this.Prioridad = prioridad;
        }

        public Nodo(T data)
        {
            this.Data = data;
        }
    }
}
