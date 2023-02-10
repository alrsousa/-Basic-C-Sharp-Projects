

using CS_CallingMethods3;
using System;


namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:   ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number if you want. Otherwise just press Enter.   ");
            string ans = Console.ReadLine();

            Calculator FirstOp = new Calculator(); //Create the object from class Calculator

            Console.WriteLine("Your input(s) + 10 = " + FirstOp.MathMethod(num1, ans));

            Console.WriteLine("********************************");
            Console.WriteLine("***** The program has ended *****");
            Console.WriteLine("********************************");

            Console.ReadLine();

        }
    }
}
