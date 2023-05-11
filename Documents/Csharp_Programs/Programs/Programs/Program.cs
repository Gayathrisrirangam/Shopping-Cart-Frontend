using System;

namespace Programs
{
    class Program
    {
  
            //check two string which are reverse of each other or not
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the first string:");
                string s1 = Console.ReadLine();
                Console.WriteLine("Enter the second string:");
                string s2 = Console.ReadLine();
                if (s1.Length != s2.Length)
                {
                    Console.WriteLine("The two strings are not reverse of each other");
                    return;
                }
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[s2.Length - i - 1])
                    {
                        Console.WriteLine("The two strings are not reverse of each other");
                        return;
                    }
                }
                Console.WriteLine("The two strings are reverse of each other");
            }
        
    }
}
