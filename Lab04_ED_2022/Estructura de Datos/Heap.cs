﻿using Lab03_ED_2022.Estructura_de_Datos;
using Lab04_ED_2022.Delegados;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab04_ED_2022.Estructura_de_Datos
{
    public class Heap<T> : IEnumerable<T>, IEnumerable
    {
        public Prioridad<T> compPrioridad { get; set; }
        public Comparar<T> HeapifyDelegate { get; set; }

        int count = 0;
        int profundidad = 0;

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
            compPrioridad(nodo.Data);
            return nodo;
        }

        public void Insertar(T data)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(data);
            asignarPrioridad(nuevoNodo);


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
            {
                if (padre.Izquierda == null)
                {
                    padre.Izquierda = newNode;
                    newNode.Padre = padre;

                    //heapify

                    Heapify(newNode);
                }
                else
                {

                    padre.Derecha = newNode;
                    newNode.Padre = padre;

                    //heapify

                    Heapify(newNode);

                }
                count++;
            }
            else
            {
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
        //clonar raiz para mostrar arbol 
        //actualizado 

        private void Heapify(Nodo<T> actual)
        {
            //nodo para almacenar temporalmente los datos 
            Nodo<T> tray = new Nodo<T>(actual.Data);

            //siempre y cuando no estemos en la raiz 
            while (actual.Padre != null)
            {

                //si la prioridad del hijo es mayor a la del padre 
                //hacer un swap de prioridad
                if (HeapifyDelegate(actual.Data,actual.Padre.Data) == 1)
                {

                    //swap de prioridad usando la bandeja 
                    //para almacenar datos temporalmente
                    tray.Data = actual.Data;
                   
                    actual.Data = actual.Padre.Data;
                    
                    actual.Padre.Data = tray.Data;
                    
                    //avanzar al padre del padre
                    Heapify(actual.Padre);
                }
                else
                {
                    //si la prioridad no es mayor 
                    //avanzar al padre del padre
                    Heapify(actual.Padre);
                }
                
            }

            return;

        }

        private void InOrder(Nodo<T> padre, ref ColaRecorrido<T> queue)
        {

            if (padre != null)
            {
                InOrder(padre.Izquierda, ref queue);
                queue.Encolar(padre.Data);
                InOrder(padre.Derecha, ref queue);
            }
            return;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var queue = new ColaRecorrido<T>();
            InOrder(raiz, ref queue);

            while (!queue.ColaVacia())
            {
                yield return queue.DesEncolar();
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
