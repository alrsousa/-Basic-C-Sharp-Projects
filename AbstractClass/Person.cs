using System;


namespace AbstractClass
{
    public abstract class Person  //Abstract method with two properties: First and Last Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);

        }
    }

}
