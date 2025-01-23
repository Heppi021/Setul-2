using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace Set2_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 1, 2, 3, 58, 96, 12, 37, 1235 };
            int s = 0;
            for (int i =0; i < v.Length; i++)
            {
                s += invers(v[i]);
            }
            Console.WriteLine(s);
            Console.ReadKey();

        }

        static int invers(int n)
        {
            int og = 0;
            while (n != 0)
            {
                og = og * 10 + n % 10;
                n /= 10;
            }
            return og; 
        }
    }
}
