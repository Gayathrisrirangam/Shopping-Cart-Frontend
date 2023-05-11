using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class charRepeatedTimes_in_String7
    {
        static void Main(string[] args)
        {
            string input = "gayathri srirangam";
            char target = 'a';
            int count = input.Count(c => c == target);
            Console.WriteLine($"The charcter '{target}' appears {count} times in the string'{input}'");
        }
    }
}
