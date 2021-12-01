using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp8
{
    internal class StatsProcessor
    {
        internal int[] Numbers { private get; set; }
        public decimal meanxyz()
        {
            int i;
            int sum = 0;
            for (i = 0; i < Numbers.Length; i++)
            {
                sum = sum + Numbers[i];
            }
            return (decimal)sum / Numbers.Length;
        }
        public int median()
        {
            //int[] a = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            Array.Sort(Numbers);
            int m = (Numbers.Length) / 2;
            //Console.WriteLine($"Median :{a[m]}");
            return Numbers[m];
        }
         public int mode()
        {
            //int[] a = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int sum = 0, maxcount = 0, maxnum = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                int count = 0;
                for (int j = 1; j < Numbers.Length - 1; j++)
                {
                    if (Numbers[i] == Numbers[j])
                    {
                        count++;
                    }
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    maxnum = Numbers[i];
                }
            }
            //Console.WriteLine($"Mode : {maxnum}");
            return maxnum;
        }


    }
}
