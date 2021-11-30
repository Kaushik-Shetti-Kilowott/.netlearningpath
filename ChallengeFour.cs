using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ChallengeFour
    {
        public static void ShowOutput()
        {
            Console.WriteLine("Challenge FOUR");
            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");
        }

    }
}
