using System;


namespace CallingMethods4
{
    public class MachineCalculator
    {
        public void ResultMethod(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine("Multiplying your numbers, we have the result ****" + result + "****");
        }

    }
}
