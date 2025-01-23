using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\data.txt");
            string[] data = load.ReadLine().Split(' ');
            int[] v = new int[data.Length];
            for (int i = 0; i<data.Length; i++)
            {
                v[i] = int.Parse(data[i]);
            }
            bool fm = false;
            bool fM = false;
            bool fe = false; 
            for (int i = 0; i < v.Length - 1; i++)
            {
                   
                if (v[i] < v[i + 1]) fm = true;
                if (v[i] > v[i + 1]) fM = true;
                if (v[i] == v[i + 1]) fe = true; 
            }
            if (fm && !fM && !fe) Console.WriteLine("Sir Strict Crescator");
            if (fm && !fM && fe) Console.WriteLine("Sir Crescator");
            if (!fm && fM && !fe) Console.WriteLine("Sir Strict Descrescator"); 
            if (!fm && fM && fe) Console.WriteLine("Sir Descrescator");
            if (!fm && !fM && fe) Console.WriteLine("Sir Egal");
            if (fm && fM) Console.WriteLine("Sir Neordonat");
            Console.ReadKey();
        }
    }
}
