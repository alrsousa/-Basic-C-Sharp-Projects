using System;


namespace Date_TimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print current time to console
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current time:   " + currentTime);


            Console.Write("Please type a number:   ");  //Requesting number from user
            string input = Console.ReadLine();

            double convertInput = double.Parse(input); //Convert the input to an integer

            //Add X to current time, X being the number the user entered
            DateTime newTime = currentTime.AddHours(convertInput); 

            //Print the result to the console
            Console.WriteLine("New calculated time:    " + newTime);

            Console.Write("");
            Console.Write("");
            Console.Write("");
            Console.WriteLine("********************************");
            Console.WriteLine("***** The program has ended *****");
            Console.WriteLine("********************************");
            Console.WriteLine("********************************");
            Console.WriteLine("***** Thank you for your attention! *****");
            Console.WriteLine("********************************");


            Console.ReadLine(); //Preventing console to be closed automatically
        }
    }
}
