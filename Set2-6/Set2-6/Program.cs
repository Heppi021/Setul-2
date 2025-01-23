using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\data.in");
            int n = int.Parse(load.ReadLine());
            string[] str = load.ReadLine().Split(' ');
            bool ok = true;
            for (int i = 0; i < n - 1; i++)
            {

                if (int.Parse(str[i]) > int.Parse(str[i + 1]))
                {
                    ok = false;
                }
            }
            Console.WriteLine(ok);
            Console.ReadKey(); 
        }
    }
}
