// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp8 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static int[] a = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };

        public static void Main(string[] args)
        {
            
            var sp = new StatsProcessor();
            sp.Numbers = a;
            var t= sp.meanxyz();
            Console.WriteLine($"Mean is {t}");

            //StatsProcessor.mean();
            var y = sp.median();
            Console.WriteLine($"Median is {y}");

            var k= sp.median();
            Console.WriteLine($"Mode is {k}");
            //StatsProcessor.median();
            //StatsProcessor.mode();
        }
    }
}