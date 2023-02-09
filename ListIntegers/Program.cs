using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        List<int> numList = new List<int>() { 1, 3, 13, 35, 69, 6680, 200, 150, 225, 590 };

        try
        {
            Console.Write("Choose a number that you like the list divided by?    ");
            int numb_div = Convert.ToInt32(Console.ReadLine());  //Receiving the divisor number


            for (int i = 0; i < numList.Count; i++)  // Entering structure to repeat the division for each element of the numList
            {
                float result = numList[i] / numb_div;
                Console.WriteLine(numList[i] + " divided by " + numb_div + "**** EQUALS **** " + result);  

            }
            Console.ReadLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type an integer number");
            Console.WriteLine("****Program ended****");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't try dividing by zero");
            Console.WriteLine("****Program ended****");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("****Program ended****");
        }
        finally
        {
            Console.ReadLine();
        }

    }
}


