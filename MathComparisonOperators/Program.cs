// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");
        for (int i = 0; i < 3; i++)
        { 
            Console.WriteLine("");
        }
// Input data and processing for Person 1
        Console.WriteLine("Person 1");
        Console.WriteLine("");
        Console.Write("Hourly Rate?  ");
        decimal lv_hour1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Hours worked per week?  ");
        int lv_hours1 = Convert.ToInt32(Console.ReadLine());
        decimal lv_total1 = (lv_hour1 * 8 * 5 * 52);

        // Input data and processing for Person 2
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("");
        }
        Console.WriteLine("Person 2");
        Console.WriteLine("");
        Console.Write("Hourly Rate?  ");
        decimal lv_hour2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Hours worked per week?  ");
        int lv_hours2 = Convert.ToInt32(Console.ReadLine());
        decimal lv_total2 = (lv_hour2 * 8 * 5 * 52);

        //Print Results
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("*********");
        }

        Console.WriteLine("Annual salary of Person 1  " + Convert.ToString(lv_total1));
        Console.WriteLine("Annual salary of Person 2  " + Convert.ToString(lv_total2));
        Console.WriteLine("Person 1 makes more money than Person 2");
        if (lv_total1 > lv_total2)
        {
            Console.WriteLine("True");
        }
        else
        { 
            Console.WriteLine("False");
        }



    }

}