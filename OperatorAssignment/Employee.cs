using System;


namespace OperatorsAssignment
{
    public class Employee//public class Employee
    {
        public string Id { get; set; }//Id property
        
        public string FirstName { get; set; }//FirstName property
        public string LastName { get; set; }//LastName property

        public static bool operator == (Employee employee1, Employee employee2)//overloaded bool operator '==' taking in employee1 and employee2
        {
            Console.WriteLine("This is comparing employee1 and employee2 Id property, and displaying 'true' if they equal each other, and false if the Id property values do not equal each other");
            Console.WriteLine("");
            return employee1.Id == employee2.Id;//returns bool value of employee1 id and employee2 id (true or false)
        }
        public static bool operator!= (Employee employee1, Employee employee2)//overloaded bool operator '!=' taking in employee1 and employee2
        {
            Console.WriteLine("This is comparing employee1 and employee2 Id property, and displaying 'true' if they do not equal each other, and false if the Id property values do equal each other");
            Console.WriteLine("");
            return employee1.Id != employee2.Id;//returns bool value of employee1 id and employee2 id (true or false)
        }

    }
}
