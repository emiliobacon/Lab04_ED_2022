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

        public Prioridad2<T> PrioridadVacia { get; set; }

        int count = 0;
        int profundidad = 0;

        Nodo<T> raiz;

        Nodo<T> copia;

        Nodo<T> último;
        public Heap()
        {
            this.raiz = null;
            this.copia = null;
            this.último = null;
        }

         

        private int Count()
        {
            return count;
        }

        public static String DecimalBinario(int contador)
        {
            long Binario = 0;
            int Divisor = 2;
            long digito = 0;
            for (int i = contador % Divisor, j = 0; contador > 0; contador /= Divisor, i = contador % Divisor, j++)
            {
                digito = i % Divisor;
                Binario += digito * (long)Math.Pow(10, j);
            }

            return Convert.ToString(Binario);
        }

        public Nodo<T> asignarPrioridad(Nodo<T> nodo)
        {
            if (PrioridadVacia(nodo.Data) == 0)
            {
                compPrioridad(nodo.Data);
                return nodo;
            }
            else
            {
                return nodo;
            }
            
        }

        public void Insertar(T data)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(data);
            asignarPrioridad(nuevoNodo);

            if (raiz == null)//vaciar nodo
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
            int max_by_level = 1; //Aquí es 1 porque no se ha modificado, no se ha desplazado.
            for (int i = 1; i <= level; i++)
            {
                max_by_level += Convert.ToInt32(Math.Pow(2, i));
                if (profundidad < i)
                { //Sacamos la profundidad actual
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
            { //Este else es la representación del desplazamiento.
              
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
                    String binario = DecimalBinario(Count() + 1);
                    if (binario.Substring(level, level + 1).Equals("0"))
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
     

        public T Elminar()
        {
            return Eliminar(raiz);
        }

        private T Eliminar(Nodo<T> actual)
        {

            Nodo<T> remplazo = new Nodo<T>(actual.Data);

            if (actual.Izquierda == null && actual.Derecha == null)
            {
                actual.Data = default(T);
                

                return remplazo.Data;
            }



            remplazo.Data = actual.Data;
            último = NodoMasDerechoso(actual);

            actual.Data = último.Data;



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

        private T Eliminar2(Nodo<T> actual)
        {

            Nodo<T> remplazo = new Nodo<T>(actual.Data);

            if (actual.Izquierda == null && actual.Derecha == null)
            {
                actual.Data = default(T); 
                return remplazo.Data;
            }

           

            remplazo.Data = actual.Data;
            último = NodoMasDerechoso(actual);

            actual.Data = último.Data;



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
                if (actual.Izquierda != null)
                {
                    if (HeapifyDelegate(actual.Izquierda.Data, actual.Data) == 1)
                    {
                        tray.Data = actual.Data;

                        actual.Data = actual.Izquierda.Data;

                        actual.Izquierda.Data = tray.Data;

                        return;
                    }
                }
                
                
                    return;
                
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
            //copia = raiz.DeepCopy();


            if (padre != null)
            {
                queue.Encolar(padre.Data);
                InOrder(padre.Izquierda, ref queue);
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
