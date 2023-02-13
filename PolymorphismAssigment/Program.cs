using System;

namespace PolymorphismAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee();
            Person.FirstName = new string("Andre Sample");
            Person.LastName = new string("Student");
            Person.SayName();
   

            IQuittable Resign = new Employee() { FirstName = "John", LastName = "Smith" };
            Resign.Quit();  //Method implemented calling the interface iquittable
            Console.ReadLine();

            Employee nEmpId1 = new Employee(10);
            Employee nEmpId2 = new Employee(20);

            if (Person.FirstName == "Andre Sample")  //Only forcing the Employee Id's to match
            {
                nEmpId2 = new Employee(10); 

            }

            
            if (nEmpId1 == nEmpId2)   
                Console.WriteLine("Employee Id's match");
            else
                Console.WriteLine("Employee Id's do not match");

        }
    }
}
