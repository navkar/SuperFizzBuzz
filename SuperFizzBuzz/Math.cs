using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Added Console flag to convenience
/// </summary>
namespace SuperFizzBuzz
{
    public class Math
    {
        private const char SEMICOLON = ';';
        private Dictionary<int, string> tokens = null;

        public Math()
        {
            // Classic tokens
            tokens = new Dictionary<int, string>()
            {
                { 3, "Fizz" },
                { 5, "Buzz" }
            };
        }

        public Math(Dictionary<int, string> tokens)
        {
            this.tokens = tokens;
        }
        
        public List<string> Sequence(int start, int end, bool isConsole = false)
        {
            var sb = new StringBuilder();

            for (int counter = start; counter <= end; counter++)
            {
                var list = new List<string>();
                bool found = false;
                foreach (var key in tokens.Keys)
                {
                    if (counter % key == 0)
                    {
                        found = true;
                        sb.Append(tokens[key]);
                        if (isConsole) Console.Write(tokens[key]);
                    }
                }

                if (!found)
                {
                    sb.Append(counter.ToString() + SEMICOLON);
                    if (isConsole) Console.WriteLine(counter.ToString());
                }
                else
                {
                    sb.Append(SEMICOLON.ToString());
                    if (isConsole) Console.WriteLine("");
                }
            }

            var result = sb.ToString().Split(SEMICOLON).ToList();
            // Last item is just newline
            result.RemoveAt(result.Count - 1);
            return result;
        }

        public List<string> Sequence(List<int> numbers, bool isConsole = false)
        {
            var sb = new StringBuilder();

            foreach (int counter in numbers)
            {
                var list = new List<string>();
                bool found = false;
                foreach (var key in tokens.Keys)
                {
                    if (counter % key == 0)
                    {
                        found = true;
                        sb.Append(tokens[key]);
                        if (isConsole) Console.Write(tokens[key]);
                    }
                }

                if (!found)
                {
                    sb.Append(counter.ToString() + SEMICOLON);
                    if (isConsole) Console.WriteLine(counter.ToString());
                }
                else
                {
                    sb.Append(SEMICOLON.ToString());
                    if (isConsole) Console.WriteLine("");
                }
            }

            var result = sb.ToString().Split(SEMICOLON).ToList();
            // Last item is just newline
            result.RemoveAt(result.Count - 1);
            return result;
        }
        
        /// <summary>
        /// EXPERIMENTATION ONLY
        /// BONUS method - fanning out computation by breaking into parts.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="isConsole"></param>
        public void FanoutSequence(int start, int end, bool isConsole = true)
        {
            int slice = (int) decimal.Divide(end, 10);
            var tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                int stop = start + slice - 1;
                if (stop > end) break;
                tasks.Add(ExecuteOnThread(() => Sequence(start, stop, true)));
                start += slice;
            }
            Task.WaitAll(tasks.ToArray());
        }

        private static async Task ExecuteOnThread(Action func)
        {
            await Task.Run(func).ConfigureAwait(false);
        }

    }
}
