using System;


namespace CallingMethods4
{
    public class MachineCalculator
    {
        public void ResultMethod(int parameter1, int parameter2)
        {
            int result = parameter1 * parameter2;
            Console.WriteLine("Multiplying your numbers, we have the result ****" + result + "****");
        }

    }
}
