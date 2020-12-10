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
        int? aux;
        int comparaciones = 0;
        int intercambios = 0;
        int index = 0;
        int?[] lista = new int?[100];

        public void Agregar(int n)
        {
            lista[index] = n;
            index++;
        }

        public string Mostrar()
        {
            string numeros = "";
            if (lista[0] != null)
            {
                for (int i = 0; i < index; i++)
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
            for (int i = 1; i < index; i++)
            {
                for (int j = 0; j < index - 1; j++)
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
            Array.Clear(lista, 0, index);
        }
    }
}