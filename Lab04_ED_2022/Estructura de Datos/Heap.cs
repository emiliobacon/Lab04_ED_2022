using Lab04_ED_2022.Delegados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04_ED_2022.Estructura_de_Datos
{
    public class Heap<T>
    {
        public Prioridad<T> compPrioridad { get; set; }

       
        public Nodo<T> asignarPrioridad(Nodo<T> nodo) 
        {
            nodo.Prioridad = compPrioridad(nodo.Data);
            return nodo;
        }         
    }

    
}
