using Lab04_ED_2022.Delegados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04_ED_2022.Estructura_de_Datos
{
    public class Heap<T>
    {
        int count = 0;
        int profundidad = 0;
        public Prioridad<T> compPrioridad { get; set; }
        Nodo<T> raiz;

        public Heap()
        {
            this.raiz = null;
        }

        private int Count()
        {
            return count;
        }

        public Nodo<T> asignarPrioridad(Nodo<T> nodo)
        {
            nodo.Prioridad = compPrioridad(nodo.Data);
            return nodo;
        }


        public void Insertar(T data)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(data);

            if (raiz == null)
            {
                raiz = nuevoNodo;
                count++;
                profundidad = 0;
            }
            else
            {
                insertInternal(raiz, nuevoNodo, 1);
            }
        }

        private void insertInternal(Nodo<T> padre, Nodo<T> newNode, int level)
        {
            int max_by_level = 1;

            for (int i = 1; i <= level; i++)
            {
                max_by_level += Convert.ToInt32(Math.Pow(2, i));
                if (profundidad < i)
                {
                    profundidad = i;
                }

            }

            if (Count() < max_by_level)
            {  //Pede ser insertado en este nivel
                if (padre.Izquierda == null)
                {
                    padre.Izquierda = newNode;
                }
                else
                {
                    padre.Derecha = newNode;
                }
                count++;

                //@pending: Comaparamos a verificar si es necesario cambiar el contenido del nodo
            }
            else
            {
                //@pending: Buscar en el siguiente nivel pero enviarle como parametro el padre que puede tenerlo


                Nodo<T> raizActual = new Nodo<T>(padre.Data);

                if (padre.Izquierda.Izquierda == null || padre.Izquierda.Derecha == null)
                {
                    raizActual = padre.Izquierda;
                }
                else if (padre.Derecha.Izquierda == null || padre.Derecha.Izquierda == null)
                {
                    raizActual = padre.Derecha;
                }
                else
                {
                    int max_CantNodos_LastLevel = Convert.ToInt32(Math.Pow(2, profundidad));
                    int variable_Selector = max_CantNodos_LastLevel / 2;
                    int max_levelAll_before = 1;
                    for (int i = 1; i < profundidad; i++)
                    {
                        max_levelAll_before += Convert.ToInt32(Math.Pow(2, i));
                    }
                    int cant_NodosLastLevel = Count() - max_levelAll_before;

                    if (cant_NodosLastLevel < variable_Selector || max_CantNodos_LastLevel == cant_NodosLastLevel)
                    {
                        raizActual = padre.Izquierda;
                    }
                    else
                    {
                        raizActual = padre.Derecha;
                    }
                }

                insertInternal(raizActual, newNode, level + 1);


            }

        }
        public void Heapify(Nodo<T> raiz)
        {

        }
    }
}
