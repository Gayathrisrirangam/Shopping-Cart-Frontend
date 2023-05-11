using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Sumconsecutive2
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, -2, 3, -4, 5, -6, 7, -8, 9 };
            int n = arr.Length;
            int minSum = int.MaxValue;
            int currsum = 0; //currsum is used to keep track of the sum of cosecutive numbers
            for (int i = 0; i < n; i++)
            {
                currsum = 0;
                for (int j = i; j < n; j++)
                {
                    currsum += arr[j];
                    if (currsum < minSum)
                    {
                        minSum = currsum;
                    }
                }
            }
            Console.WriteLine("The smallest sum of consecutive number is" + minSum);
        }
    }
}
