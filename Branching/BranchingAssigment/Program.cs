// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("****************");
        }



        Console.Write("Please enter package weight:  ");
        int weight = Convert.ToInt32(Console.ReadLine());
        if (weight > 50)
        {
        //User entered weight  greater than 50, do below code
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("****************");
            }
            Console.WriteLine("Program ended");
            Console.ReadLine();
        }
        else //Weight not greater than 50
        {
            Console.Write("Please enter package width:  ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter package height:  ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter package length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int total = width + height + length;

            if (total > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine("****************");
                }
                Console.WriteLine("Program ended");
                Console.ReadLine();
            }
            else            {
                Console.WriteLine("Calculating your estimated shipping cost...");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("****************");
                }

                int quote = height * width * length * weight;
                int finalQuote = quote / 100;//divides 'quote' variable by 100 to get total shipping cost
                Console.WriteLine("Your estimated total for shipping this package is: $" + finalQuote + " Thank you!");//displays string along with 'finalQuote' variable concatenated inside of string
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("****************");
                }
                Console.WriteLine("Program ended");
                Console.ReadLine();

            }

        }



    }


}