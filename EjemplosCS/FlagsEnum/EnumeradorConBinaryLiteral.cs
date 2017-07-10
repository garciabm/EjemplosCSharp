namespace FlagsEnum
{
    using System;

    /// <summary>
    /// Si no compila comenta este enumerador, C# 7 es necesario
    /// </summary>
    [Flags]
    enum EnumeradorConBinaryLiteral
    {
        Valor1 = 0b0001,
        Valor2 = 0b0010,
        Valor3 = 0b0100,
        Valor4 = 0b1000
    }
}
