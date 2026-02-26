using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro-não negativo: ");
            byte n = byte.Parse(Console.ReadLine());
            // Divisão por 2
            int div2 = n / 2;
            Console.WriteLine(div2);
            //Shift left por 3
            int shiftLeft = n << 3;
            Console.WriteLine(shiftLeft);
            // XOR com 6
            int XOR6 = n ^ 6;
            Console.WriteLine(XOR6);
            // Se é maior que 10
            bool maior10 = n > 10;
            Console.WriteLine(maior10);
        }
    }
}
