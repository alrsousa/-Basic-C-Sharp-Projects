// See https://aka.ms/new-console-template for more information
using System;

class Program
{

    static void Main()
    {
        Console.Write("Guess a number day of the month?   ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isGuessed = number == DateTime.Today.Day;
        do
        {
            switch (number)
            {

                case 29:
                    Console.WriteLine("You guessed the number 29. That is correct!");
                    isGuessed = true;
                    break;

                default:
                    Console.WriteLine("You are wrong. The number is not  " + Convert.ToString(number));
                    Console.Write("Guess a number day of the month?   ");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;

            }

        }

        //loops the program until user enters correct number 29
        while (!isGuessed);

            }

        }

        




