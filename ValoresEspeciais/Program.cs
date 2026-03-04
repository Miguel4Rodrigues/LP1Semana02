using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== Max e Min Values ===\n");

            Console.WriteLine($"byte: Min = {byte.MinValue}, Max = {byte.MaxValue}");
            Console.WriteLine($"sbyte: Min = {sbyte.MinValue}, Max = {sbyte.MaxValue}");
            Console.WriteLine($"short: Min = {short.MinValue}, Max = {short.MaxValue}");
            Console.WriteLine($"ushort: Min = {ushort.MinValue}, Max = {ushort.MaxValue}");
            Console.WriteLine($"int: Min = {int.MinValue}, Max = {int.MaxValue}");
            Console.WriteLine($"uint: Min = {uint.MinValue}, Max = {uint.MaxValue}");
            Console.WriteLine($"long: Min = {long.MinValue}, Max = {long.MaxValue}");
            Console.WriteLine($"ulong: Min = {ulong.MinValue}, Max = {ulong.MaxValue}");
            Console.WriteLine($"float: Min = {float.MinValue}, Max = {float.MaxValue}");
            Console.WriteLine($"double: Min = {double.MinValue}, Max = {double.MaxValue}");
            Console.WriteLine($"decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}");

            Console.WriteLine("\n=== Valores Especiais ===\n");

            // double
            Console.WriteLine($"double +∞ = {double.PositiveInfinity}");
            Console.WriteLine($"double -∞ = {double.NegativeInfinity}");
            Console.WriteLine($"double NaN = {double.NaN}");

            // float
            Console.WriteLine($"float +∞ = {float.PositiveInfinity}");
            Console.WriteLine($"float -∞ = {float.NegativeInfinity}");
            Console.WriteLine($"float NaN = {float.NaN}");

            // Overflow em uint
            Console.WriteLine("\n=== Overflow em uint ===\n");

            uint u = uint.MaxValue;
            Console.WriteLine($"Antes: {u}");
            u++;
            Console.WriteLine($"Depois de +1: {u}");

            // Overflow em float
            Console.WriteLine("\n=== Overflow em float (+∞) ===");

            float f1 = float.MaxValue;
            Console.WriteLine($"Antes: {f1}");
            f1 *= 2;
            Console.WriteLine($"Depois *2: {f1}");

            Console.WriteLine("\n=== Overflow float (-∞) ===");

            float f2 = -float.MaxValue;
            Console.WriteLine($"Antes: {f2}");
            f2 *= 2;
            Console.WriteLine($"Depois *2: {f2}");
        }
    }
}