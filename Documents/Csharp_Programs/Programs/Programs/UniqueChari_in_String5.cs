using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class UniqueChari_in_String5
    {
        static void Main(string[] args)
        {
            string input = "Gayathri Srirangam";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            //count the number of occurrences of each character in the input string
            foreach (char c in input)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            //print the unique characters
            foreach (KeyValuePair<char, int> pair in dict)
            {
                if (pair.Value == 1)
                {
                    Console.WriteLine(pair.Key);
                }
            }
        }
    }
}
