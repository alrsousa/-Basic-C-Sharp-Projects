// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
// Receiving a number, after multiplying it by 50 and printing the result. The ?lv_num1 means variable can be nulled by the user
        Console.Write("Type one number:  ");
        double ?lv_num1 = double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);
        lv_num1 = 50 * lv_num1;
        Console.WriteLine("The result of entered number times 50 is equal  " + lv_num1);
// Receiving another number, adding 25 and printing the result
        Console.Write("Type another number:  ");
        int lv_num2 = Convert.ToInt16(Console.ReadLine());
        lv_num2 = 25 + lv_num2;
        Console.WriteLine("The result of entered number adding 25 is equal  " + lv_num2);
// Receiving third number, dividing by 12.5 and printing the result
        Console.Write("Type one number:  ");
        double lv_num3 = Convert.ToDouble(Console.ReadLine());
        lv_num3 = lv_num3 / 12.5;
        Console.WriteLine("The result of entered number divided by 12.5 is equal  " + lv_num3);
// Receiving another number, checking if is greater than 50 and printing the result
        Console.Write("Type another number:  ");
        int lv_num4 = Convert.ToInt16(Console.ReadLine());
        if (lv_num4 > 50) {
            Console.WriteLine("The entered number is greather than 50  " + "True");
        }
        else
        {
            Console.WriteLine("The entered number isn´t greather than 50  " + "False");
        }
//Receiving the fifth number, dividing by 7 and printing the remainder
        Console.Write("Type another number:  ");
        int lv_num5 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("The remainder of input number divided by 7 is " + Convert.ToString(lv_num5 % 7));





    }  //    END OF static void Main()





}

