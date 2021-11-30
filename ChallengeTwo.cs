using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ChallengeTwo
    {
        public static void ShowOutput()
        {
            Console.WriteLine("Challenge TWO");
            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;

            Console.WriteLine("Hello, ");
            Console.WriteLine(name);
            Console.WriteLine("! You have ");
            Console.WriteLine(messages);
            Console.WriteLine(" in your inbox. The temperature is ");
            Console.WriteLine(temperature);
            Console.WriteLine(" celsius.");
        }
    }
}
