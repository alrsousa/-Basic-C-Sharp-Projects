

using System;


namespace AbstractClass
{

    public class Employee : Person

    {
        public override void SayName()  //Inherited from Person Class
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

    }
}
