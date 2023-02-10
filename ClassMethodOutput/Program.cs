using System;

namespace ClassMethodOutputAssigment
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.Write("Please type a number:   ");
            string line = Console.ReadLine();
            var operatorObject = new Calculator();

            if (int.TryParse(line, out int Num))
            {
                Console.WriteLine("Your INTEGER number divided by 2 is EQUAL ****  " + operatorObject.GetDiv(Num));
            }
            else if (decimal.TryParse(line, out decimal Dec))
            {
                Console.WriteLine("Your DECIMAL number divided by 2 is EQUAL ****   " + operatorObject.GetDiv(Dec));
            }
            else if (operatorObject.GetDiv(line, out int stgNum))
            {
                Console.WriteLine(stgNum);
            }
            else
            {
                Console.WriteLine("Your input is invalid!!!");
            }


            Console.WriteLine("********************************");
            Console.WriteLine("***** The program has ended *****");
            Console.WriteLine("********************************");

            Console.ReadLine();


        }

    }


}