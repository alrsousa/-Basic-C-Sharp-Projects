
using System;

namespace PolymorphismAssigment
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()  //Method inherited override
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        
        int n;
        public Employee()
        {
            n = 0;
        }
        public Employee(int EmpId1)
        {
            n = EmpId1;
        }

        public static bool operator ==(Employee EmpId1, Employee EmpId2)
        {
            if (EmpId1.n == EmpId2.n)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee EmpId1, Employee EmpId2)
        {
            if (EmpId1.n != EmpId2.n)
                return true;
            else
                return false;
        }

        public int getValue()  //This method is not being used, but he could return the Employee ID
        {
            return n;
        }
    }
}
