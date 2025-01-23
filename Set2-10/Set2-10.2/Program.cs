using System;
using System.IO;

namespace Set2_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\data.txt");
            string[] tmp = load.ReadLine().Split(' ');
            int[] v = new int[tmp.Length];
            int s = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                v[i] = int.Parse(tmp[i]);
            }
            int crtnr = v[0];
            int crtap = 1;
            int maxnr = v[0];
            int maxap = 1;
            for (int i = 1; i < v.Length; i++)
            {
                if (v[i] == crtnr) crtap++;
                else
                {
                    if (crtap > maxap)
                    {
                        maxnr = crtnr;
                        maxap = crtap; 
                    }
                    crtnr = v[i];
                    crtap = 1; 
                }
            }
            Console.WriteLine(maxnr + " apara de " + maxap + " ori");
            Console.ReadKey();

        }
    }
}
