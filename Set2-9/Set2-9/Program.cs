using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c;
            double l; 
            int n = int.Parse(Console.ReadLine());
            for(int i = 2; i<=n; i++)
            {
                c = a + b;
                l = (double)c / b; 
                a = b;
                b = c;
                Console.WriteLine(l.ToString("0.0000"));
            }
            Console.ReadKey();
        }
    }
}
