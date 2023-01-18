// See https://aka.ms/new-console-template for more information
using System;
//using System.Collections.Generic; // use for lists


class Program
{
    static void Main()
    {
        string[] transport = { "Car", "Boat", "Bus", "Airplane", "Train", "Ship" };
        Console.Write("Choose a number from 0-5 and that will be your transport next vacations   ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        if (number1 == 0 || number1 == 1 || number1 == 2 || number1 == 3 || number1 == 4 || number1 == 5)
        {
            Console.WriteLine("You will have " + transport[number1] + " for next vacations!");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Out of bounds. That's not a valid choice.");
        }


        int[] numArray = { 3, 7, 9, 27, 55, 79 };
        Console.Write("Choose a number from 0-5 and that will reveal your mystery number for the day   ");
        int RandomNum = Convert.ToInt32(Console.ReadLine());
        if (RandomNum == 0 || RandomNum == 1 || RandomNum == 2 || RandomNum == 3 || RandomNum == 4 || RandomNum == 5)
        {
            Console.WriteLine("Your Random number for today is  " + numArray[RandomNum]);
            Console.WriteLine("");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Out of bounds. That's not a valid choice.");

        }

        List<string> intList = new List<string> { "Green", "White", "Blue", "Red", "Yellow", "Orange" };

        Console.Write("Choose a number from 0-5 and that will be your color   ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 0 || number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
        {
            Console.WriteLine("The number you choosen is color " + intList[number]);
            Console.WriteLine("");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Out of bounds.That's not a valid choice.");
        }

    }
}

