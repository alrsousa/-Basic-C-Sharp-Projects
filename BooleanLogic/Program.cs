// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
//The driver must be aged more than 15 in order for drive
        Console.Write("What is your age?   ");
        int age = Convert.ToInt32(Console.ReadLine());
        bool drive = age > 15;

        Console.Write("Have you ever had a DUI?(True/False)    ");
        string ?answer = Console.ReadLine();
        bool dui = Convert.ToBoolean(answer);
// Speed ticket must be hold value not greater than 3
        Console.Write("How many speeding tickets do you have?   ");
        int ?speed = Convert.ToInt32(Console.ReadLine());
        bool ticket = 3 >= speed;
 //boolean variables 'drive' and 'tickets' must hold true, while 'dui' must hold false value in order to result be True. 
        Console.WriteLine("Qualified?   " + (drive == true && dui == false && ticket == true));




    }



}

