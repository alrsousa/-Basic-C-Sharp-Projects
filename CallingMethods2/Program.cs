using System;
using Calculator;

namespace ClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            decimal num2 = 70.69m;
            string str1 = "70";
            int num3 = Int32.Parse(str1);

            Calculadora FirstOp = new Calculadora();
            Calculadora SecondOp = new Calculadora();
            Calculadora ThirdOp = new Calculadora();
            Console.WriteLine(FirstOp.MathMethod(10));
            Console.WriteLine(SecondOp.MathMethod(10, 70.69m));
            Console.WriteLine(ThirdOp.MathMethod(10, 70.69m, str1));
            Console.WriteLine("********************************");
            Console.WriteLine("***** The program has ended *****");
            Console.WriteLine("********************************");
            Console.ReadLine();

        }
    }
}