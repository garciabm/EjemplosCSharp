using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleTask
{
    class Program
    {
        static List<Producto> productos = new List<Producto>();
        static int orden = 1; 

        static void DefineMenu()
        {
            productos.Add(new Producto { TiempoElaboracion = TimeSpan.FromSeconds(7), Nombre = "Hamburguesa", Opcion = 1 });
            productos.Add(new Producto { TiempoElaboracion = TimeSpan.FromSeconds(3), Nombre = "HotDog", Opcion = 2 });
        }

        static void Main(string[] args)
        {
            DefineMenu();
            bool activo = true;
            List<Task> tasks = new List<Task>();
            while (activo)
            {
                Console.WriteLine("¿Que desea Ordenar?");
                string opcion = Console.ReadLine();
                if (opcion == "c")
                {
                    activo = false;
                    Console.WriteLine("Esperando todas las ordenes");
                    Task.WaitAll(tasks.ToArray());
                    Console.WriteLine("Hasta Luego");
                }
                else
                {
                    Task task = Task.Factory.StartNew(() => Ejecuta(Convert.ToInt32(opcion)));
                    tasks.Add(task);
                    //Ejecuta(Convert.ToInt32(opcion));
                }
            }
        }

        public static void Ejecuta(int valor)
        {
            Producto producto = productos.FirstOrDefault(c => c.Opcion == valor);
            if (producto != null)
            {
                int ordenAsignada = orden;
                orden++;
                Console.WriteLine(string.Format("Preparando {0} orden {1}", producto.Nombre, ordenAsignada));
                Thread.Sleep(producto.TiempoElaboracion);
                Console.WriteLine(string.Format("Orden {0} lista, sale {1}",ordenAsignada, producto.Nombre));
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Opción no Valida");
            }
        }
    }
}
