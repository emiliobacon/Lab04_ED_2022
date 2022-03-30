using Lab03_ED_2022.Estructura_de_Datos;
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
        public Comparar<T> CompararNodos { get; set; }


        int count = 0;
        int profundidad = 0;

        Nodo<T> raiz;
        Nodo<T> último;
        public Heap()
        {
            this.raiz = null;
            this.último = null;
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
                InsertInternal(raiz, nuevoNodo, 1);
            }
        }

        private void InsertInternal(Nodo<T> padre, Nodo<T> newNode, int level)
        {
            int max_by_level = 1;

            for (int i = 1; i <= level; i++)
            {
                max_by_level += Convert.ToInt32(Math.Pow(2, i));
                if (profundidad < i) //saco la profundidad actual 
                {
                    profundidad = i;
                }
            }

            if (Count() < max_by_level)
            {  //Puede ser insertado en este nivel
                if (padre.Izquierda == null)
                {
                    padre.Izquierda = newNode;
                    newNode.Padre = padre;

                    Heapify(newNode);
                }
                else
                {
                    padre.Derecha = newNode;
                    newNode.Padre = padre;

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
                else if (padre.Derecha.Izquierda == null || padre.Derecha.Derecha == null)
                {
                    raizActual = padre.Derecha;
                }
                else
                {
                    int max_CantNodos_LastLevel = Convert.ToInt32(Math.Pow(2, profundidad));
                    int variable_Selector = max_CantNodos_LastLevel / Convert.ToInt32(Math.Pow(2, level));
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

                InsertInternal(raizActual, newNode, level + 1);


            }
        }
        //clonar raiz para mostrar arbol 
        //actualizado 

        public T Elminar()
        {
            return Eliminar(raiz);
        }

        private T Eliminar(Nodo<T> actual)
        {
            Nodo<T> remplazo = new Nodo<T>(actual.Data);

            remplazo.Data = actual.Data;
            último = NodoMasDerechoso(actual);

            actual.Data = último.Data;

            if (actual.Izquierda == null && actual.Derecha == null)
            {
                actual = null;
                return remplazo.Data;
            }
            
            if (CompararNodos(último.Data, último.Padre.Izquierda.Data) == 0)
            {
                último.Padre.Izquierda = null;
                último.Padre = null;
            }
            else
            {
                último.Padre.Derecha = null;
                último.Padre = null;
            }

            HeapifyInverso(actual);

            return remplazo.Data;

        }
        private void Heapify(Nodo<T> actual)
        {
            //nodo para almacenar temporalmente los datos 
            Nodo<T> tray = new Nodo<T>(actual.Data);

            //siempre y cuando no estemos en la raiz 
            if (actual.Padre != null)
            {

                //si la prioridad del hijo es mayor a la del padre 
                //hacer un swap de prioridad
                if (HeapifyDelegate(actual.Data, actual.Padre.Data) == 1)
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
            else
            {
                return;
            }

        }

        private void HeapifyInverso(Nodo<T> actual)
        {
            Nodo<T> tray = new Nodo<T>(actual.Data);

            if (actual.Izquierda != null && actual.Derecha != null)
            {
                if (HeapifyDelegate(actual.Izquierda.Data, actual.Derecha.Data) == 1)
                {
                    if (HeapifyDelegate(actual.Data, actual.Izquierda.Data) == -1)
                    {
                        tray.Data = actual.Data;

                        actual.Data = actual.Izquierda.Data;

                        actual.Izquierda.Data = tray.Data;

                        HeapifyInverso(actual.Izquierda);
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    if (HeapifyDelegate(actual.Data, actual.Derecha.Data) == -1)
                    {
                        tray.Data = actual.Data;

                        actual.Data = actual.Derecha.Data;

                        actual.Derecha.Data = tray.Data;

                        HeapifyInverso(actual.Derecha);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                try
                {
                    if (HeapifyDelegate(actual.Izquierda.Data, actual.Data) == 1)
                    {
                        tray.Data = actual.Data;

                        actual.Data = actual.Izquierda.Data;

                        actual.Izquierda.Data = tray.Data;

                        return;
                    }
                }
                catch (Exception)
                { 
                    return;
                }      
            } 
        }

        private int AlturaIzquierda(Nodo<T> nodo)
        {
            int c = 0;
            while (nodo != null)
            {
                c++;
                nodo = nodo.Izquierda;
            }

            return c; 
        }

        private Nodo<T> NodoMasDerechoso(Nodo<T> nodo)
        {
            int h = AlturaIzquierda(nodo);

            if (h == 1)
            {
                return nodo;
            }
            else if ((h -1) == AlturaIzquierda(nodo.Derecha))
            {
                return NodoMasDerechoso(nodo.Derecha);
            }        
               return NodoMasDerechoso(nodo.Izquierda);
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
