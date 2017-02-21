using System;

namespace TernaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Debugear con F11 para entrar a los métodos
            EjemploIf();
            Console.WriteLine(Environment.NewLine);
            EjemploTernary();
            Console.WriteLine(Environment.NewLine);
            EjemploTernaryDoble();
            Console.WriteLine(Environment.NewLine);


            EjemploOperadorTernarioAnidado();
            Console.WriteLine(Environment.NewLine);

            EjemploOperadorTernaryDobleAnidado();

            Console.ReadKey();
        }

        private static void EjemploOperadorTernarioAnidado()
        {
            Console.WriteLine(AsignacionTernaryAnidado(1));
            Console.WriteLine(AsignacionTernaryAnidado(2));
            Console.WriteLine(AsignacionTernaryAnidado(3));
            Console.WriteLine(AsignacionTernaryAnidado(4));
            Console.WriteLine(AsignacionTernaryAnidado(5));

        }

        private static string AsignacionTernaryAnidado(int parametroNum)
        {
            string valorReturn;
            valorReturn = parametroNum == 1 ? "uno" : parametroNum == 2 ? "dos" : parametroNum == 3 ? "tres" : parametroNum == 4 ? "cuatro" : "default";
            return valorReturn;
        }

        private static void EjemploOperadorTernaryDobleAnidado()
        {
            Console.WriteLine(AsignacionDobleTernaryAnidado("valor1", "valor2", "valor3", "valor4"));
            Console.WriteLine(AsignacionDobleTernaryAnidado(null, "valor2", "valor3", "valor4"));
            Console.WriteLine(AsignacionDobleTernaryAnidado(null, null, "valor3", "valor4"));
            Console.WriteLine(AsignacionDobleTernaryAnidado(null, null, null, "valor4"));
        }

        private static string AsignacionDobleTernaryAnidado(string val1, string val2, string val3, string val4)
        {
            string resultado = val1 ?? val2 ?? val3 ?? val4;
            return resultado;
        }

        /// <summary>
        /// Ejemplo para asignación de valores con un if
        /// </summary>
        private static void EjemploIf()
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

        /// <summary>
        /// Ejemplo para asignación con el operador ternario ? :
        /// </summary>
        private static void EjemploTernary()
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

        /// <summary>
        /// Ejemplo para asignación de valores con operador ?? (Null coalescing operator)
        /// </summary>
        private static void EjemploTernaryDoble()
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

        private static string AsignacionIf(string cadena)
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

        private static string AsignacionTernary(string cadena)
        {
            string resultado;
            // variable = condición ? valorSiSeCumpleCondicion : valorSiNoSeCumpleCondicion
            resultado = cadena == null ? "cadena es nula" : cadena;
            return resultado;

        }

        private static string AsignacionTernaryDoble(string cadena)
        {
            string resultado;
            //variable = valorAsignarSiNoEsNulo ?? valorAsignarEnCasoDeQueSeaNulo
            resultado = cadena ?? "cadena es nula";
            return resultado;
        }

    }
}
