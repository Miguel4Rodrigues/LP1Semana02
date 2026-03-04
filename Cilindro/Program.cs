using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== Cilindro ===");
            Console.Write("Altura: ");
            double Altura = double.Parse(Console.ReadLine());
            Console.Write("Raio: ");
            double Raio = double.Parse(Console.ReadLine());
            double Volume = Math.PI * Math.Pow(Raio,2) * Altura;
            Console.WriteLine($"Volume = {Volume:f3}");
        }
    }
}
