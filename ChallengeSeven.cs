using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ChallengeSeven
    {
        public static void ShowOutput()
        {

            Console.WriteLine("Challenge SEVEN");
            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string orderID in orderIDs)
            {
                if (orderID.StartsWith("B"))
                {
                    Console.WriteLine(orderID);
                }
            }
        }

    }
}
