
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp7
{
    internal class stats
    {
        public static void Calculate_stats()
        {
            int[] a= { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int sum = 0, maxcount = 0, maxnum = 0;
            decimal mean = 0;
            foreach (int test in a)
            {
                sum = sum + test;
            }
            mean = (decimal)sum / a.Length;
            Console.WriteLine($"Mean :{mean}");
            Array.Sort(a);
            int m = (a.Length) / 2;
            Console.WriteLine($"Median :{a[m]}");
            for (int i = 0; i < a.Length; i++)
            {
                int count = 0;
                for (int j = 1; j < a.Length - 1; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    maxnum = a[i];
                }
            }
            Console.WriteLine($"Mode : {maxnum}");
        }
    }
}