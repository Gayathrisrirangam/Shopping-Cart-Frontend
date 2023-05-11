using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _13
    {
        public static void Main()
        {
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();

            if (IsAnagram(str1, str2))
            {
                Console.WriteLine("The strings are anagram.");
            }
            else
            {
                Console.WriteLine("The strings are not anagram.");
            }
        }
        public static bool IsAnagram(string str1, string str2)
        {
            if(str1.Length !=str2.Length)
            {
                return false;
            }
            int[] charCounts = new int[256];
            foreach(char c in str1)
            {
                charCounts[(int)c]++;
            }
            foreach (char c in str2)
            {
                charCounts[(int)c]--;
            }
            foreach(int count in charCounts)
            {
                if(count !=0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
