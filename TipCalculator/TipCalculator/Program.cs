using System;
using System.Runtime;

namespace TipCalculator
{
    
    class Program
    {

        static void Main(String[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welcome to my Tip Calculator!!!");
            Console.WriteLine("Write the total of the bill: ");
            double bill = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose your tip:\n\t[1] 10%\n\t[2] 20%\n\t[3] 50%\n\t[4] Custom Tip");

            switch(i)
            {
                case 1:
                    bill += (bill * 0.10);
                    Console.WriteLine("The total of your bill is: " + bill);
                    break;

                case 2:
                    bill += (bill * 0.20);
                    Console.WriteLine("The total of your bill is: " + bill);
                    break;

                case 3:
                    bill += (bill * 0.50);
                    Console.WriteLine("The total of your bill is: " + bill);
                    break;

                case 4:
                    Console.WriteLine("Enter a custom tip: ");
                    int customTip = Convert.ToInt32(Console.ReadLine());
                    bill += (bill * (customTip / 100));
                    break;
            }

            Console.ReadKey();
        }
    }
}
