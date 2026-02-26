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
            Console.Write("Unit (C/F): ");
            string Unit = Console.ReadLine();
            string response;
        
            switch (Unit)
            {
                case "C":
                    double Fahrenheit = Temp * 1.8 + 32;
                    response = $"{Temp:f2} C = {Fahrenheit:f2} F";
                    Console.WriteLine(response);
                    break;

                case "F":
                    double Celsius = (Temp - 32) / 1.8;
                    response = $"{Temp:f2} F = {Celsius:f2} C";
                    Console.WriteLine(response);
                    break;
            }


        }
    }
}
