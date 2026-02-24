using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro: ");
            int numeroInteiro = int.Parse(Console.ReadLine());
            int decremento = --numeroInteiro;
            int incremento = ++numeroInteiro;
            Console.WriteLine(decremento);
            Console.WriteLine(incremento);
        }
    }
}
