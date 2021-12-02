using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StatsProcessor
    {
        internal int [] Numbers { private get; set; }

        internal StatsResult GetStatsProcessorResult()
        {
            var result=new StatsResult();
            result.Mean = CalculateAverage();
            result.Median = CalculateMedian();
            result.Mode = CalculateMode();
            return result;
        }

        //private int CalculateAverage() => Numbers.Sum() / Numbers.Length;


        private decimal CalculateAverage()
        {
            int i;
            int sum = 0;
            for (i = 0; i < Numbers.Length; i++)
            {
                sum = sum + Numbers[i];
            }
            return (decimal)sum / Numbers.Length;
        }
        //private int CalculateMedian()
        //{
        //    var s = Numbers.OrderBy(i => i).ToArray();
        //    var n = s.Length;
        //    var m = n % 2 == 0
        //        ? (s[n / 2 - 1] + s[n / 2]) / 2
        //    :s[n / 2];
        //    return m;
        //}

        private int CalculateMedian()
        {
            Array.Sort(Numbers);
            int m = (Numbers.Length) / 2;
            //Console.WriteLine($"Median :{a[m]}");
            return Numbers[m];
        }

        private int CalculateMode()
        {
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
