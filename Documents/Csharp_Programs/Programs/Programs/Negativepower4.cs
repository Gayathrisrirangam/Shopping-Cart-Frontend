using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Negativepower4
    {
        static void Main(string[] args)
        {
            double basenum = 2.0;
            int exponent = -3;
            double result = 1.0;
            for (int i = 0; i > exponent; i--)
            {
                result *= 1 / basenum;
            }
            Console.WriteLine($"Result: {result}");
        }
    }
}
