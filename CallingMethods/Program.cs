// See https://aka.ms/new-console-template for more information
using System;
using CS_Class_Methods;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number to do 3 math functions with it:   ");
            int numb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numb + " + 500 *** EQUALS *** " + Calculator.Add(numb));
            Console.WriteLine(numb + " x 50  *** EQUALS *** " + Calculator.Mult(numb));
            Console.WriteLine(numb + " - 100 *** EQUALS *** " + Calculator.Subtract(numb));
            Console.WriteLine("********************************");
            Console.WriteLine("***** The program has ended *****");
            Console.WriteLine("********************************");
            Console.ReadLine();
        }
    }
}

