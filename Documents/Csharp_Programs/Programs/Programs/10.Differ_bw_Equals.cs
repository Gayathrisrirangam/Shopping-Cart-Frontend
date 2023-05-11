using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _10
    {
        static void Main(string[] args)
        {
            string str1 = "srirangam";
            string str2 = "srirangam";
            //if(str1==str2) //using ==
            //{
            //    Console.WriteLine("String1 and string2 are same"); 
            //}

            if (str1.Equals(str2)) //using equals()
            {
                Console.WriteLine("String1 and string2 are same");
            }
        }
    }
}
