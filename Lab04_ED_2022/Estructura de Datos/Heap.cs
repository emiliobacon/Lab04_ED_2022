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

        Nodo<T> raiz;
        public Heap()
        {
            this.raiz = null;
        }

       
        public Nodo<T> asignarPrioridad(Nodo<T> nodo) 
        {
            nodo.Prioridad = compPrioridad(nodo.Data);
            return nodo;
        }

        public void Insertar(T data)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(data);
            Insertar(nuevoNodo, raiz);
        }

        private void Insertar(Nodo<T> nuevo, Nodo<T> padre)
        {
            
            if (padre == null)
            {
                padre = nuevo;
            }
            else
            {
                if (padre.Izquierda == null)
                {
                    padre.Izquierda = nuevo;
                    
                }
                else if (padre.Derecha == null)
                {
                    padre.Derecha = nuevo;
                }
                else
                {
                    Insertar(nuevo, padre.Izquierda);
                }

                
            }
        }

        public void Heapify(Nodo<T> raiz)
        { 

        }

    }

    
}
