using System;
using System.Collections.Generic;
using SuperFizzBuzz;

/// <summary>
/// A second console application demonstrating advanced usage of SuperFizzBuzz
/// Print the numbers from -12 through 145.
/// For multiples of 3, print “Fizz”
/// </summary>
namespace AdvancedFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 7, "Buzz" },
                { 38, "Bazz" },
            };

            var moreTokens = new Dictionary<int, string>
            {
                { 4, "Frog" },
                { 13, "Duck" },
                { 9, "Chicken" },
            };

            try
            {
                var advanced = new SuperFizzBuzz.Math(tokens);

                Console.WriteLine("* * * [-12 to 145] with custom tokens * * * ");
                // -ve to +ve
                PrintToConsole(advanced.Sequence(-12, 145));
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            // Frog, Chicken and Duck

            try
            {
                var moreAdvanced = new SuperFizzBuzz.Math(moreTokens);

                Console.WriteLine("* * * FROG / DUCK / CHICKEN * * * ");
                PrintToConsole(moreAdvanced.Sequence((new List<int> { 52, 36, 468 })));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            Console.ReadLine();
            Console.WriteLine("Press Enter to Exit");
        }

        private static void PrintToConsole(List<string> items)
        {
            foreach (string item in items)
            {
                Console.Write(item);
            }
        }
    }
}
