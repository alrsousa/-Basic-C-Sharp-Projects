using System;
using System.Collections.Generic;


namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try//try block to control exceptions
            {
                Console.Write("Please enter the current day of the week:    ");//displays message asking user to input the day of the week
                string userInput = Console.ReadLine();//saves user input as string variable 
                DaysOfTheWeek.Day day =(DaysOfTheWeek.Day)Enum.Parse(typeof(DaysOfTheWeek.Day), userInput);//creates variable 'day' from 'DaysOfTheWeek.Day' and parses it by defining its type, and what is being parsed, also passing in userInput
                Console.WriteLine("You entered a valid day... Have a great " + day + "!");//Displays message 
            }
            catch//catch block, executes if above block runs into an error
            {
                Console.WriteLine("Please enter an actual valid day of the week.");//Displays message
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("********************************");
            Console.WriteLine("***** The program has ended *****");
            Console.WriteLine("********************************");
            Console.WriteLine("********************************");
            Console.WriteLine("***** Thank you for your attention! *****");
            Console.WriteLine("********************************");

            Console.ReadLine();
        }
    }
}
