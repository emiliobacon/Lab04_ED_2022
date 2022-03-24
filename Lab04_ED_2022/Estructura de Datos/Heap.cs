using Lab04_ED_2022.Delegados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04_ED_2022.Estructura_de_Datos
{
    public class Heap<T>
    {
        private int count;

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
            if (raiz == null)
            {
                Nodo<T> nuevoNodo = new TreeNode<K, V>(getPriority(value), value);
                raiz = nuevoNodo;
                count++;
            }
            else
            {

            }
        }



        public int Count()
        {
            return count;
        }

        private void insertarInterno(Nodo<T> padre,Nodo<T> nuevo,  int nivel)
        {
            int maximoNivel = 0;
            for (int i = 0; i < nivel; i++)
            {
                maximoNivel += Convert.ToInt32(Math.Pow(2, i));
            }
            if (Count() < maximoNivel)
            {
                if (padre.Izquierda == null)
                {
                    padre.Izquierda = nuevo;
                }
                else
                {
                    padre.Derecha = nuevo;
                }
                count++;

                //heapify

            }
            else
            {
                insertarInterno(padre.Derecha, nuevo, nivel + 1);
            }
        }

    }

    
}
