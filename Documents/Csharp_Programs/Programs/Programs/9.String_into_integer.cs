using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _9
    {
        static void Main(string[] args)
        {
            string strNumber = "123";
            int number;
            if (int.TryParse(strNumber, out number))
            {
                Console.WriteLine(number); //output :123
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
