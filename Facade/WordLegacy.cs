using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Assignment2.Facade
{
    internal static class WordLegacy
    {
        internal static readonly List<char> One = new();
        internal static readonly List<char> Two = new();
        internal static readonly List<char> Three = new();
        internal static readonly List<char> Four = new();
        internal static readonly List<char> Five = new();

        internal static void Save(string input)
        {
            if (input.Length != 5)
            {
                Console.WriteLine("Exiting program - Error - The string needs to be EXACTLY 5 characters long");
                Console.ReadKey(true);
            }
            else
            {
                One.Add(input[0]);
                Two.Add(input[1]);
                Three.Add(input[2]);
                Four.Add(input[3]);
                Five.Add(input[4]);
            }
        }

        internal static void Load()
        {
            if (One.Count > 0)
            {
                char[] word = { One.Last(), Two.Last(), Three.Last(), Four.Last(), Five.Last() };
                Console.WriteLine(word);
            }
        }
    }
}
