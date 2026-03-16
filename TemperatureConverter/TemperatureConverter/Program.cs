using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to my temperature converter (Cº -> Fº)");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            Console.Write("Choose your temperature (Cº): ");
            double c = Convert.ToDouble(Console.ReadLine());

            double f = (c * 9 / 5) + 32;
            
            Console.WriteLine(c + "º Celsius will be " + f + "º Fahrenheit");

            Console.ReadKey();
        }
    }
}