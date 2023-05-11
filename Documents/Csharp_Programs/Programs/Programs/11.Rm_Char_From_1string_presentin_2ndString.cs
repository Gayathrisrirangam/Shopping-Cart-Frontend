using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class _11  
    {
        static void Main(string[] args)
        {
            string str1 = "gayathri srirangam";
            string str2 = "air";
            StringBuilder sb = new StringBuilder(str1);
            //remove charcters from 1st string that present in 2nd string
            for (int i = 0; i < sb.Length; i++)
            {
                if (str2.Contains(sb[i]))
                {
                    sb.Remove(i, 1);
                    i--;
                }
            }
            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
