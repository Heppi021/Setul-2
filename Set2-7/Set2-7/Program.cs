using System;
using System.Collections.Generic;
using System.IO;

namespace Set2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\resources\data2.txt");
            string buffer;
            List<int> t = new List<int>();
            while ((buffer = load.ReadLine()) != null)
            {
                string[] local = buffer.Split(' ');
                for(int i = 0; i<local.Length; i++)
                {
                    t.Add(int.Parse(local[i]));
                }
            }
            int[] v = new int[t.Count];
            for (int i = 0; i<v.Length; i++)
            {
                v[i] = t[i];
            }
            int min = v[0];
            int max = v[0];
            for(int i = 0; i<v.Length; i++)
            {
                if (min > v[i]) min = v[i];
                if (max < v[i]) max = v[i]; 
            }
            Console.WriteLine(min);
            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
