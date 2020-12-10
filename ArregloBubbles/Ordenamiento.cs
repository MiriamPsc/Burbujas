using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloBubbles
{
    class Ordenamiento
    {
        int aux;
        int comparaciones = 0;
        int intercambios = 0;
        int[] lista;

        public void Agregar(int rango, int may, int men)
        {
            lista = new int[rango]; 
            Random random = new Random();
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = random.Next(men, may);
            }
        }

        public string Mostrar()
        {
            string numeros = "";
            if (lista.Length!=0)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    numeros += lista[i] + ", ";
                }
                return numeros;
            }
            else
            {
                return "LA LISTA ESTÁ VACÍA.";
            }

        }

        public string Ordenar()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < lista.Length; i++)
            {
                for (int j = 0; j < lista.Length - 1; j++)
                {
                    comparaciones++;
                    if (lista[j] > lista[j + 1])
                    {
                        aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                        intercambios++;
                    }
                }
            }
            stopwatch.Stop();
            string time = $"    Tiempo = {stopwatch.Elapsed.TotalMilliseconds } ms.";
            Mostrar();
            return "Comparaciones = " + comparaciones + "  Intercambios = " + intercambios + time;
        }

        public void VaciarLista()
        {
            Array.Clear(lista, 0, lista.Length);
        }
    }
}