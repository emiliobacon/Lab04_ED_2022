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
                }
                else
                {
                    padre.Derecha = newNode;
                }
                count++;

                //@pending: Comaparamos a verificar si es necesario cambiar el contenido del nodo
            }
            else
            { //Este else es la representación del desplazamiento.
              //@pending: Buscar en el siguiente nivel pero enviarle como parametro el padre que puede tenerlo


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

                insertInternal(raizActual, newNode, level + 1);
            }

        }
        public void Heapify(Nodo<T> raiz)
        {

        }
    }
}
