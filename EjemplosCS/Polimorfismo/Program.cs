using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////
            //Polimorfismo                                      //
            //                                                  //
            //Es la   habilidad que   poseen los   objetos para //
            //reaccionar de  modo diferente  ante los  mismos   //
            //mensajes                                          //
            ///////////////////////////////////////////////////////////////////////////////////////////
            //   Referencia                                                                          //
            // http://www.itnuevolaredo.edu.mx/takeyas/Apuntes/POO/Apuntes/04.-Polimorfismo.pdf      //
            //                                                                                       //
            ///////////////////////////////////////////////////////////////////////////////////////////

            List<FiguraGeometrica> figurasGeometricas = new List<FiguraGeometrica>();
            figurasGeometricas.Add(new CuadradoOverride());
            figurasGeometricas.Add(new RectanguloOverride());

            // Gracias al polimorfismo usando virtual y override los objetos contenidos en la lista pueden responder de distinta manera

            foreach (FiguraGeometrica figuraGeometrica in figurasGeometricas)
            {
                Console.WriteLine(figuraGeometrica.CalcularArea());
            }

            Console.WriteLine(Environment.NewLine);

            figurasGeometricas = new List<FiguraGeometrica>();
            figurasGeometricas.Add(new CuadradoSinOverride());
            figurasGeometricas.Add(new RectanguloSinOverride());

            // Sin el override se va a usar el método de la clase base, evitando reaccionar de manera distinta dependiendo de la figura

            foreach (FiguraGeometrica figuraGeometrica in figurasGeometricas)
            {
                Console.WriteLine(figuraGeometrica.CalcularArea());
            }

            Console.WriteLine(Environment.NewLine);

            //A falta de Override para tener el area de todas las figuras se tendría que hacer algo parecido a lo siguiente
            //Lo que para agregar y obtener el area de una figura geométrica nueva se tendría que modificar el foreach para que acepte la nueva figura

            foreach (FiguraGeometrica figuraGeometrica in figurasGeometricas)
            {
                if (figuraGeometrica is CuadradoSinOverride)
                {
                    Console.WriteLine((figuraGeometrica as CuadradoSinOverride).CalcularArea());
                }

                if (figuraGeometrica is RectanguloSinOverride)
                {
                    Console.WriteLine((figuraGeometrica as RectanguloSinOverride).CalcularArea());
                }
            }

            Console.ReadKey();
        }
    }
}
