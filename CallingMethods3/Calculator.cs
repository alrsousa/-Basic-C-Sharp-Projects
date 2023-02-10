using System;

namespace CS_CallingMethods3
{
    public class Calculator    {
        public int MathMethod(int num1, string ans)
        {
            int result = 0;
            if (ans == "") //When user didn´t typed the second Number
            {
                result = num1 + 10;

            }
            else //Calculate using the 2 inputed numbers + 10
            {
                int num2 = Convert.ToInt32(ans);
                result = num1 + num2 + 10;
            }
            return result;

        }

    }
}
