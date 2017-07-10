namespace FlagsEnum
{
    using System;

    [Flags]
    enum EnumeradorGrande : long // Int64
    {
        ValorX = 1L,
        //.
        //.
        //.
        ValorY = 1L << 45,
        //.
        //.
        //.
        ValorZ = 1L << 63,
    }
}
