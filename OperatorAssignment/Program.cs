using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();//instantiate Employee object 'employee1'
            employee1.Id = "1";//sets value of Id property to 1
            employee1.FirstName = "James";//sets value of FirstName property to 'James'
            employee1.LastName = "Hetfield";//sets value of Last Name property to 'Hetfield'

            Employee employee2 = new Employee();//instantiates Employee object 'employee2'
            employee2.Id = "2";//sets value of employee1.Id property to 2
            employee2.FirstName = "Kirk";//sets value of FirstName property to 'Kirk'
            employee2.LastName = "Hammet";//sets value of LastName property to 'Hammet'

            Console.WriteLine(employee1 == employee2);//display to console bool value of 'is employee1 equal to employee2?'
            Console.WriteLine(employee1 != employee2);//display to console bool value of 'is employee1 not equal to employee2?'


            Console.WriteLine("********************************");
            Console.WriteLine("***** The program has ended *****");
            Console.WriteLine("********************************");
            Console.WriteLine("********************************");
            Console.WriteLine("***** Thank you for your attention! *****");
            Console.WriteLine("********************************");


            Console.ReadLine();//ensures console remains open


        }
    }
}
