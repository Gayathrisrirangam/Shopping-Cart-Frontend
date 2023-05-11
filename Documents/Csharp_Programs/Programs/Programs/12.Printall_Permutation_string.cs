using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _12
    {
        static void Main()
        {
            string input = "srirangam";
            Permute(input);
        }
        static void Permute(string str)
        {
            Permute(str.ToCharArray(), 0, str.Length - 1);
        }
        static void Permute(char[] arr, int i, int n)
        {
            if (i == n)
                Console.WriteLine(new string(arr));
            else
            {
                for(int j=i; j<=n; j++)
                {
                    Swap(ref arr[i], ref arr[j]);
                    Permute(arr, i + 1, n);
                    Swap(ref arr[i], ref arr[j]);
                }
            }
        }
        static void Swap(ref char a,ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }
    }
}
