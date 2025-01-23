using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Set2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool nugasit = true;
            int poz = 0; 
            TextReader load = new StreamReader(@"..\..\data.in");
            int n = int.Parse(load.ReadLine()); 
            string[] str = load.ReadLine().Split(' ');
            int a = int.Parse(load.ReadLine()); 
            for (int i = 0; i < str.Length; i++)
            {
                int x = int.Parse(str[i]);
                if (a == x)
                {
                    nugasit = false;
                    Console.WriteLine(i);  
                }
            }
            if (nugasit) Console.WriteLine(-1); 
            Console.ReadKey();
        }
    }
}
