using System;

namespace Program
{

    class Program
    {

        static void Main(string[] args)
        {
            int sum = 0;
            int multiply = 1;
            double division = 1;

            Console.WriteLine("Choose the total of numbers: ");
            int qnt =  Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qnt; i++)
            {
                Console.WriteLine("Insert a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                multiply *= number;
                division /= number;

            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Multiply: {multiply}");
            Console.WriteLine($"Division: {division}");

            Console.ReadKey();
        }

    }
}