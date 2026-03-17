using System;
using System.ComponentModel.Design;

namespace numberGuessingGame
{

    class Program
    {

        static void Main(string[] args)
        {
            int number = Random.Shared.Next(1, 101);

            Console.WriteLine("Welcome to GuessDaNumber!!!");
            Console.ReadKey();
            Console.WriteLine("Guess the number win 1000€");
            Console.ReadKey();
            Console.Write("Write your guess (1-100): ");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess != number)
            {
                if (guess > 100 || guess < 0)
                {
                    Console.Write("Invalid Option!\n");
                } else if (guess > number)
                {
                    Console.Write("Your guess was to high!\n");
                } else
                {
                    Console.WriteLine("Your guess was to low!\n");
                } 

                Console.Write("Your last guess was " + guess + "\nEnter a new number: ");

                guess = Convert.ToInt32(Console.ReadLine());
            
            }

            Console.Write("Congrats!!! You got it right!\n");
            Console.ReadKey();

        }
    }
}