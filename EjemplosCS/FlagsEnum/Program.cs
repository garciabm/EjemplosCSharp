namespace FlagsEnum
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            //Asignaciones
            #region Asignaciones
            Virtud virtud = Virtud.Amigable | Virtud.Generoso;
            Console.WriteLine(virtud);

            virtud = (Virtud)5; //Virtud.Amigable | Virtud.Generoso
            Console.WriteLine(virtud);
            #endregion

            //Comprobaciones
            #region Comprobaciones
            bool tieneBandera = (virtud & Virtud.Generoso) == Virtud.Generoso;
            Console.WriteLine(tieneBandera);
            //Mensaje en consola "True"

            tieneBandera = (virtud & Virtud.Servicial) == Virtud.Servicial;
            Console.WriteLine(tieneBandera);
            //Mensaje en consola "False"

            tieneBandera = virtud.HasFlag(Virtud.Generoso);
            Console.WriteLine(tieneBandera);
            //Mensaje en consola "True"

            tieneBandera = virtud.HasFlag(Virtud.Servicial);
            Console.WriteLine(tieneBandera);
            //Mensaje en consola "False"
            #endregion

            //Toggle con XOR
            #region Toggle con XOR
            virtud = Virtud.Responsable | Virtud.Servicial | Virtud.Generoso;
            Console.WriteLine(virtud);
            //Mensaje en consola "Generoso, Servicial, Responsable"

            virtud = virtud ^ Virtud.Servicial;
            Console.WriteLine(virtud);
            //Mensaje en consola: "Generoso, Responsable"

            virtud = virtud ^ Virtud.Servicial;
            Console.WriteLine(virtud);
            //Mensaje en consola "Generoso, Servicial, Responsable"
            #endregion

            //Complemento bit a bit
            #region Complemento bit a bit
            virtud = virtud & ~Virtud.Responsable;
            Console.WriteLine(virtud);
            //Mensaje en consola "Generoso, Servicial"
            #endregion

            //Agrupaciones
            #region Agrupaciones
            DiaDeLaSemana dia = DiaDeLaSemana.Sabado;

            bool esFinDeSemana = DiaDeLaSemana.FinDeSemana.HasFlag(dia);

            DiaDeLaSemana dias = DiaDeLaSemana.Lunes | DiaDeLaSemana.Miercoles | DiaDeLaSemana.Jueves;
            bool esEntreSemana = DiaDeLaSemana.EntreSemana.HasFlag(dias);
            Console.WriteLine(esEntreSemana);
            //Mensaje en consola "True"

            dias = DiaDeLaSemana.Lunes | DiaDeLaSemana.Miercoles | DiaDeLaSemana.Sabado;
            esEntreSemana = DiaDeLaSemana.EntreSemana.HasFlag(dias);
            Console.WriteLine(esEntreSemana);
            //Mensaje en consola "False"
            #endregion

            //Sin y con atributo Flags
            #region Sin y con atributo Flags
            Console.WriteLine(EnumSinAtributo.ValorX | EnumSinAtributo.ValorY);
            //Mensaje en consola "3"
            Console.WriteLine(EnumConAtributo.ValorX | EnumConAtributo.ValorY);
            //Mensaje en consola "ValorX, ValorY"
            #endregion
        }
    }
}
