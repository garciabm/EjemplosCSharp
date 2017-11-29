using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia de arreglo de enteros
            int[] arreglo = new int[5];

            //asignar valor a cada indice (empezando por 0)
            arreglo[0] = 10;
            arreglo[1] = 20;
            arreglo[2] = 30;
            arreglo[3] = 40;
            arreglo[4] = 50;

            //iterar arreglo e imprimir valores
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }

            //pausa en pantalla
            Console.ReadKey();

        }
    }
}
