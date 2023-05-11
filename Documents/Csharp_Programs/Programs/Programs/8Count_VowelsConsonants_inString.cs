using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _8Count_VowelsConsonants_inString
    {
        static void Main(string[] args)
        {
            string str = "gayathri srirangam";
            int vowelCount = 0, consonantCount = 0;
            foreach (char c in str.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    consonantCount++;
                }
            }
            Console.WriteLine("Number of vowels: " + vowelCount);
            Console.WriteLine("Number of Consonants: " + consonantCount);
        }
    }
}
