using System;
using System.Globalization;

namespace TempConvert
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Temperature: ");
            double Temp = double.Parse(Console.ReadLine());
            Console.Write("Unit: ");
            string Unit = Console.ReadLine();
        }
    }
}
