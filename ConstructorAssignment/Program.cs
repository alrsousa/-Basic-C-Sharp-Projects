using System;


namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Constant Variable
            const string programName = "Constructor Andre Sousa";

            Console.Write("This is my constant variable for the:   {0}", programName);
            Console.WriteLine("Hit any key to continue... ");
            Console.ReadLine();
            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Please type anything:    ");
            var anyThing = Console.ReadLine(); //variable using "var"
            Console.Write("You wrote:    " + anyThing);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("********************************");
            Console.WriteLine("***** The program has ended *****");
            Console.WriteLine("********************************");
            Console.WriteLine("********************************");
            Console.WriteLine("***** Thank you for your attention! *****");
            Console.WriteLine("*** Andre Sousa 2023 - All rights reserved ****");
            Console.WriteLine("********************************");

            Console.ReadLine();
        }
            //Chained constructors
            class Foo
        {
            private int id;
            private string name;

            public Foo() : this(0, "")
            {
            }

            public Foo(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public Foo(int id) : this(id, "")
            {
            }

            public Foo(string name) : this(0, name)
            {
            }
        }
    }
}
