// See https://aka.ms/new-console-template for more information
using System;


class Program
{
    static void Main()
    {
        //Assignment part 1
        string[] names = { "Andrew ", "Trevor ", "Samuel ", "Matthew ", "James ", "Tom " };//Dimensional array of strings
        Console.Write("Please input some text:   ");
        string ?answer = Console.ReadLine(); //Stores user input inside 
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = names[i] + answer;//concatenates user input 'answer' to end of 'names'
        }

        for (int i = 0; i < names.Length; i++)//for loop iterates through 'names' 
        {
            Console.WriteLine(names[i]);//displays 'name' with 'answer' concatenated with all previous strings
        }

        //Assignment part 2
        while (true)//indicates while () is true, which allows this to loop an infinite amount of times
        {
            Console.WriteLine("***** Fixing the infinite Loop *****");//prints while above statement is true
            break;//Will stop looping after Writing the message above 'Console.WriteLine()'
        }
        //Assignment part 3 
        for (int i = 0; i < 15; i++)//set i to 0, while i is less than 15, add one to i on each iteration
        {
            Console.WriteLine("First loop: " + i);//prints iterations of i, again, while its less than 15
        }
        for (int i = 0; i <= 15; i++)//set i to 0, while i is less than or equal to 12, add one to i on each iteration
        {
            Console.WriteLine("Second loop: " + i);//prints iterations of i
        }

        //Assignment part 4
        List<string> teams = new List<string>()//list of individual unique strings
            { "SPFC", "Palmeiras", "Real Madrid",
                "Liverpool", "Ponte Preta", "Barcelona",  "Halifax Wanderers"
            };
        Console.Write("Please try to search for an soccer team!     ");
        string? search = Console.ReadLine();//Saves user input inside 'search' string variable 

        if (teams.Contains(search))//if loop, if list 'teams' contains user input 'search' do the following
        {
            var matchingIndicies = teams
            .Select((x, i) => new { Name = x, Index = i })
            .Where(x => x.Name == search)
            .Select(x => x.Index);
            foreach (var index in matchingIndicies)//foreach loop iterates through elements of 'teams'
            {
                Console.WriteLine("Position:   " + index);//displays index
            }
            Console.WriteLine("This is a team in the list!");//displays to console
        }
        else//executes if 'if' loop does not execute
        {
            Console.WriteLine("This team is not in the list.");//displays to console 
        }

        //Assignment part 5
        List<string> choose = new List<string>()//creates list of strings 
            { "SPFC is the major soccer team in Brasil", "SPFC is the major soccer team in Brasil" };//two identical strings
        Console.WriteLine("Please input, \'SPFC is the __ soccer team in Brasil\" with the blank space filled in with his number rank to try and find the duplicate string!");
        string select = Console.ReadLine();//has user input saved as string variable in 'select'

        if (choose.Contains(select))//if loop, if list 'choose' contains user input 'select' execute if loop
        {
            var indicies = choose
            .Select((a, i) => new { Name = a, Index = i })
            .Where(a => a.Name == select)
            .Select(a => a.Index);
            foreach (var index in indicies)//foreach loop iterates through collection in 'choose'
            {
                Console.WriteLine(index);//displays index
            }
            Console.WriteLine("Your input is the duplicate string!");
        }
        else//executes if 'if' loop does not meet condition
        {
            Console.WriteLine("Your input is not in the list.");
        }
        //Assignment part 6 
        List<string> monthUnique = new List<string>()//creates list of strings containing two duplicate strings
            { "January", "February", "March", "April", "May", "June", "July",  "January"};
        //creates second empty list
        List<string> monthDup = new List<string>() { };

        foreach (var x in monthUnique)//foreach loop to iterate through list of strings
        {
            if (monthDup.Contains(x))//if monthUnique contains item in list 'x' execute below code
            {
                Console.WriteLine(x + " This string is a duplicate string.");//adds item from list 'x' and displays message
                monthDup.Add(x);//adds item from list 'x' to empty list 
            }
            else
            {
                Console.WriteLine(x + " This string is a unique string.");//adds item from list 'x' and displays message
                monthDup.Add(x);//adds item 'x' to empty list
            }
        }

        Console.ReadLine();//Makes console remains opened
    }



}