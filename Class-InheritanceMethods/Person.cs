
using System;


namespace ClassInherithanceMethods
{
    public class Person
    {
        //Gets and setters for properties First and Last Name
        public string FirstName { get; set; }  
        public string LastName { get; set; }

        public void SayName()  
        {
                Console.WriteLine("Name: " + FirstName + "  " + LastName);
            
        }

    }
}
