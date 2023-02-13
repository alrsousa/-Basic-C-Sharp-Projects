
using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee();
            Person.FirstName = new string("Andre Sousa");
            Person.LastName = new string("Student");
            Person.SayName();
            //Console.ReadLine();

            //            IQuittable Resign = new Employee() { FirstName = "John", LastName = "Smith" };
            //            Resign.Quit();
            //            Console.ReadLine();

            //            Employee nEmpId1 = new Employee(5);
            //            Employee nEmpId2 = new Employee(15);

            //if (nEmpId1 == nEmpId2)   
            //Console.WriteLine("Employee Id's match");
            //else
            //Console.WriteLine("Employee Id's do not match");

        }
    }
}
