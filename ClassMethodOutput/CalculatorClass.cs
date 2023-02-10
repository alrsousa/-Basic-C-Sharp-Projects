using System;

namespace ClassMethodOutputAssigment
{
    class Calculator  //Class used to calculate values with distinct DataTypes
    {
        public int GetDiv(int data)  //Calculating for integer input
        {
            return data / 2;
        }

        public int GetDiv(decimal data)  //Calculating for decimal input after converted to integer
        {
            int intNum = Convert.ToInt32(data);
            return intNum / 2;
        }

        public bool GetDiv(string data, out int stgNum)
        {
            if (int.TryParse(data, out int intNum))
            {
                stgNum = intNum / 2;
                return true;
            }
            else
            {
                stgNum = 0;
                return false;
            }

        }

    }

}

