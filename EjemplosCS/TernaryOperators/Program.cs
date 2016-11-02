using System;

namespace TernaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            EjemploIf();
            EjemploTernary();
            EjemploTernaryDoble();
            Console.ReadKey();
        }

        public static void EjemploIf()
        {
            string variableCadena = null;
            string resultado = string.Empty;

            resultado = AsignacionIf(variableCadena);

            Console.WriteLine(resultado);

            variableCadena = "Algo";
            resultado = string.Empty;

            resultado = AsignacionIf(variableCadena);

            Console.WriteLine(resultado);
        }

        public static void EjemploTernary()
        {
            string variableCadena = null;
            string resultado = string.Empty;

            resultado = AsignacionTernary(variableCadena);

            Console.WriteLine(resultado);

            variableCadena = "Algo";
            resultado = string.Empty;

            resultado = AsignacionTernary(variableCadena);

            Console.WriteLine(resultado);
        }

        public static void EjemploTernaryDoble()
        {
            string variableCadena = null;
            string resultado = string.Empty;

            resultado = AsignacionTernaryDoble(variableCadena);

            Console.WriteLine(resultado);


            variableCadena = "Algo";
            resultado = string.Empty;

            resultado = AsignacionTernaryDoble(variableCadena);

            Console.WriteLine(resultado);
        }

        public static string AsignacionIf(string cadena)
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

        public static string AsignacionTernary(string cadena)
        {
            string resultado;
            resultado = cadena == null ? "cadena es nula" : cadena;
            return resultado;

        }

        public static string AsignacionTernaryDoble(string cadena)
        {
            string resultado;
            resultado = cadena ?? "cadena es nula";
            return resultado;
        }

    }
}
