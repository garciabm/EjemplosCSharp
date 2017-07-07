using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// En proceso
/// </summary>
namespace FlagsEnum
{
    [Flags]
    public enum Nivel 
    {
        Usuario = 1,
        Gerente = 2,
        //Administrador = Gerente << 1
        Administrador = 4
    }

    [Flags]
    enum Permiso
    {
        Lectura = 1,
        Escritura = 2,
        Modificar = 4,
        Borrar = 8,
        Crear = 16
    }

    [Flags]
    public enum DiasDeLaSemana //: long
    {
        Lunes = 1 << 0,
        Martes = 1 << 1,
        Miercoles = 1 << 2,
        Jueves = 1 << 3,
        Viernes = 1 << 4,
        Sabado = 1 << 5,
        Domingo = 1 << 6,
        //Algo = ((long)1) <<(63),
        //Algo2 = 1 << 34,
        EntreSemana = Lunes | Martes | Miercoles | Jueves | Viernes,
        FinDeSemana = Sabado | Domingo
        

    }

    enum Color
    {
        Azul = 0, 
        Rojo = 1,
        Amarillo = 2,
        Negro = 3,
        Blanco = 4
    }
    [Flags]
    enum Virtud
    {
        Amigable = 1,
        Compasivo = 2,
        Generoso = 4,
        Servicial = 8,
        Responsable = 16
    }

    class Program
    {
        /// <summary>
        /// Ejemplo en proceso
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Color colorMesa = Color.Amarillo;
            Color colorSilla = Color.Azul;

            Virtud virtud = (Virtud)5;//Virtud.Amigable | Virtud.Generoso;
            Console.WriteLine(virtud);

            DiasDeLaSemana diaS = DiasDeLaSemana.Sabado | DiasDeLaSemana.Domingo;

            Permiso perm = Permiso.Escritura | Permiso.Lectura;
            perm = perm & ~Permiso.Escritura;
            //perm = perm ^ Permiso.Escritura;
            //perm = perm ^ Permiso.Escritura;

            //bool esI = DiasDeLaSemana.Lunes == DiasDeLaSemana.Algo;

            byte valor = (byte)Nivel.Usuario;
            byte valor1 = (byte)Nivel.Gerente;
            //byte valor2 = (byte)Nivel.Administrador;

            DiasDeLaSemana dia = DiasDeLaSemana.Sabado;

            bool esFinDeSemana = DiasDeLaSemana.FinDeSemana.HasFlag(dia);

            bool esFinDeSemana2 = (dia & DiasDeLaSemana.FinDeSemana) == dia;

            DiasDeLaSemana diaEntre = DiasDeLaSemana.Lunes | DiasDeLaSemana.Miercoles | DiasDeLaSemana.Sabado;

            bool esEntreSemana = DiasDeLaSemana.EntreSemana.HasFlag(diaEntre);

            bool esEntreSemana2 = (diaEntre & DiasDeLaSemana.EntreSemana) == diaEntre;



            Nivel prueba = Nivel.Gerente | Nivel.Usuario;

            bool EsAdministrador = prueba >= Nivel.Administrador;

            bool EsGerente = (prueba & Nivel.Gerente) == Nivel.Gerente;

        }
    }
}
