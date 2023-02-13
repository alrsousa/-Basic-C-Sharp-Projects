using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//instantiate employee object 
            List<Employee> newList = new List<Employee> {//creates new list from Employee
                new Employee() {Id = 1, FirstName = "James", LastName = "Hetfileld"}, //instantiate object, and give values to properties (Id, FirstName and LastName)
                new Employee(){Id =2, FirstName = "Kirk", LastName = "Hammet"}, //instantiate object, and give values to properties
                new Employee(){Id= 3, FirstName = "Jason", LastName = "Newsted"}, //instantiate object, and give values to properties
                new Employee(){Id = 4, FirstName =  "Cliff", LastName =  "Burton"}, //instantiate object, and give values to properties
                new Employee(){Id = 5, FirstName = "Bruce", LastName =  "Dickinson"}, //instantiate object, and give values to properties
                new Employee(){Id = 6, FirstName = "Andre", LastName = "Mattos"}, //instantiate object, and give values to properties
                new Employee(){Id = 7, FirstName = "Frank", LastName = "Sinatra"}, //instantiate object, and give values to properties" 
                new Employee(){Id = 8, FirstName = "Nicko", LastName = "McBrain"},//instantiate object, and give values to properties
                new Employee(){Id = 9, FirstName =  "Ozzy", LastName = "Osbourne"}, //instantiate object, and give values to properties
                new Employee(){Id = 10, FirstName = "Dave", LastName =  "Murray" } //instantiate object, and give values to properties
            };
            List<Employee> newList2 = new List<Employee>();//creates new list from employee
            foreach (Employee boxer in newList)//foreach loop, finding value in 'newList'
            {
                if ( boxer.FirstName == "James")//if FirstName equals Joe, execute below code
                {
                    newList2.Add(boxer);//add value 'boxer' to 'newList2'
                }
                
            }
            List<Employee> jamesList = newList.Where(x => x.FirstName == "James").ToList();//creates new list from Employee. Finds values from newList, if property FirstName equals Joe, add to list 'joeList'
            List<Employee> jamesList2 = newList.Where(x => x.Id > 5).ToList();//creates a new list from Employee. Finds values from newList, if property Id is greater than 5, add to list 'joeList2'


            //Print the values stored in the lists
            //            jamesList2.ForEach(i => Console.Write("{0} \n", i));  //print colletion to console
            jamesList2.ForEach(n => Console.WriteLine(n.FirstName + "  " + n.LastName + "   ID:  " + n.Id));


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
