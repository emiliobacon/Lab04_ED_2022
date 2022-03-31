using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04_ED_2022.Estructura_de_Datos
{
    public class Nodo<T>
    {
        public T Data { get; set; }

        public Nodo<T> Izquierda { get; set; }
        public Nodo<T> Derecha { get; set; }
        public Nodo<T> Padre { get; set; }

        public Nodo(T data)
        {
            this.Data = data;

        }

     

    }
}

