using System;
using System.Collections.Generic;


namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> emp1 = new Employee<string>(1, "Ricardo", "Tarantino"); //Adding values to Employee collection emp1
            emp1.things = new List<string>() { "Ricardo", "Tarantino", "has been", "hired." };
            emp1.things.ForEach(i => Console.Write("{0} ", i));  //print colletion to console
            Console.ReadLine();

            Employee<int> emp2 = new Employee<int>(2, "Juan Pablo", "Montoya"); //Adding values to Employee collection emp2
            emp2.things = new List<int>() { 22, 35, 14, 47 };
            emp2.things.ForEach(i => Console.Write("{0} \n", i));  //print colletion to console
            Console.ReadLine();

            Console.WriteLine("********************************");
            Console.WriteLine("***** The program has ended *****");
            Console.WriteLine("********************************");
            Console.WriteLine("********************************");
            Console.WriteLine("***** Thank you for your attention! *****");
            Console.WriteLine("********************************");


        }
    }
}
