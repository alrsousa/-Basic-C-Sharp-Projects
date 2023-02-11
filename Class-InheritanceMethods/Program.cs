using System;

namespace ClassInherithanceMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee();
            Person.FirstName = new string("Andre");
            Person.LastName = new string("Sousa Student");
            Person.SayName();
            Console.WriteLine("********************************");
            Console.WriteLine("***** The program has ended *****");
            Console.WriteLine("********************************");
            Console.WriteLine("********************************");
            Console.WriteLine("********************************");
            Console.WriteLine("***** Thank you for your attention! *****");
            Console.WriteLine("********************************");

            Console.ReadLine();
  
        }
    }
}
