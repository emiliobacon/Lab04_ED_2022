using Lab04_ED_2022.Estructura_de_Datos;
using Lab04_ED_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04_ED_2022.Helpers
{
    public class Data
    {
        private static Data _instance = null;
        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }

        public Heap<ModeloPaciente> miHeap = new Heap<ModeloPaciente>
        {
            compPrioridad = Delegados.Delegados.SetPrioridad,
            HeapifyDelegate = Delegados.Delegados.HeapifyDelegate
        };
    }
}
