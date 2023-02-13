using System;


namespace PolymorphismAssigment
{
    interface IQuittable   //Method implemented as interface to inform the worked is not working anymore with us
    {
        void Quit()
        {
            Console.WriteLine("This Employee don't work anymore for our company");
        }
    }
}
