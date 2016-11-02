using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            string variableCadena = null;
            string resultado = string.Empty;

            resultado = EjemploIf(variableCadena);
            //resultado = EjemploTernary(variableCadena);
            //resultado = EjemploTernaryDoble(variableCadena);

            Console.WriteLine(resultado);
           

            variableCadena = "Algo";
            resultado = string.Empty;


            resultado = EjemploIf(variableCadena);
            //resultado = EjemploTernary(variableCadena);
            //resultado = EjemploTernaryDoble(variableCadena);

            Console.WriteLine(resultado);
            Console.ReadKey();


        }

        public static string EjemploIf(string cadena)
        {
            string resultado;
            if (cadena == null)
            {
                resultado = "cadena es nula";
            }
            else
            {
                resultado = cadena;
            }
            return resultado;
        }

        public static string EjemploTernary(string cadena)
        {
            string resultado;
            resultado = cadena == null ? "cadena es nula" : cadena;
            return resultado;

        }

        public static string EjemploTernaryDoble(string cadena)
        {
            string resultado;
            resultado = cadena ?? "cadena es nula";
            return resultado;
        }
       
    }
}
