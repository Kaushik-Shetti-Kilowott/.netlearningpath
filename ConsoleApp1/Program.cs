// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static int[] a = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
        static void Main(string [] args)
        {
            var spObject=new StatsProcessor();
            spObject.Numbers = a;
            var result = spObject.GetStatsProcessorResult();
            Console.WriteLine($"Average:{result.Mean}");
            Console.WriteLine($"Median:{result.Median}");
            Console.WriteLine($"Mode:{result.Mode}");
        }
    }
}
