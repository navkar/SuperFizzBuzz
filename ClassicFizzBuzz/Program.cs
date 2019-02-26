using System;
using System.Collections.Generic;
using SuperFizzBuzz;

namespace ClassicFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sequential - 1, 100
            Console.WriteLine("* * * Sequential - (1, 100) * * *");
            var classic = new SuperFizzBuzz.Math();
            PrintToConsole(classic.Sequence(1, 100));

            Console.WriteLine("* * * Any set of integers * * * ");
            // Any set of integers
            PrintToConsole(classic.Sequence((new List<int> { 12, 34, 45, 500 })));

            Console.WriteLine("* * * [-1 to 35] * * * ");
            // -ve to +ve
            classic.Sequence(-1, 35, true);
            
            //Console.WriteLine("* * * [1 - 1,000,0000,000] * * * ");
            // 1 to 1 Billion
            //classic.FanoutSequence(1, 1000000000);

            Console.ReadLine();
            Console.WriteLine("Press Enter to Exit");
        }


        private static void PrintToConsole(List<string> items)
        {
            foreach(string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
