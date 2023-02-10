using CallingMethods4;
using System;

namespace Calling_Methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number:     ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please choose a second number:     ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            MachineCalculator FirstOp = new MachineCalculator();
            FirstOp.ResultMethod(parameter1: number1, parameter2: number2);

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
