using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Set2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\data.i");
            int n = int.Parse(load.ReadLine());
            string[] str = load.ReadLine().Split(' ');
            int z = 0;
            int p = 0;
            int neg = 0;  
            for (int i = 0; i < n; i++)
            { 
                int m = int.Parse(str[i]);
                if (m == 0) z++;
                else if (m > 0) p++;
                else if (m < 0) neg++;

            }
            Console.WriteLine("Zero:" + z);
            Console.WriteLine("Pozitive:" + p);
            Console.WriteLine("Negative:" + neg);
            Console.ReadKey();
        }
    }
}
