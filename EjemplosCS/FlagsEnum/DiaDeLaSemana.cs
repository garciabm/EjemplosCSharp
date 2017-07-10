namespace FlagsEnum
{
    using System;

    [Flags]
    public enum DiaDeLaSemana
    {
        Lunes = 1 << 0,
        Martes = 1 << 1,
        Miercoles = 1 << 2,
        Jueves = 1 << 3,
        Viernes = 1 << 4,
        Sabado = 1 << 5,
        Domingo = 1 << 6,
        EntreSemana = Lunes | Martes | Miercoles | Jueves | Viernes,
        FinDeSemana = Sabado | Domingo
    }
}
