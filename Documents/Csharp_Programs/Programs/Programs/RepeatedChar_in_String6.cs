using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class RepeatedChar_in_String6
    {
        static void Main(string[] args)
        {
            string inputString = "gayathri Srirangam";
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            //Count the occurences of each character
            foreach (char c in inputString)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts.Add(c, 1);
                }
            }
            //print the repeated characters
            foreach (KeyValuePair<char, int> pair in charCounts)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine("'{0}' is repeated {1} times.", pair.Key, pair.Value);
                }
            }
        }
    }
}
