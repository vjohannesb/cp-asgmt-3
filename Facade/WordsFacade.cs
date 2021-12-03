using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Assignment2.Facade
{
    internal static class WordsFacade
    {
        private static readonly List<char> _one = new();
        private static readonly List<char> _two = new();
        private static readonly List<char> _three = new();
        private static readonly List<char> _four = new();
        private static readonly List<char> _five = new();

        internal static void Save()
        {
            Console.WriteLine("Enter a word with precisely 5 characters: ");

            string input = Console.ReadLine();
            if (input.Length != 5)
            {
                Console.WriteLine("Exiting program - Error - The string needs to be EXACTLY 5 characters long");
                Console.ReadKey(true);
            }
            else
            {
                _one.Add(input[0]);
                _two.Add(input[1]);
                _three.Add(input[2]);
                _four.Add(input[3]);
                _five.Add(input[4]);
            }
        }

        internal static void Load()
        {
            if (_one.Count > 0)
            {
                Console.Write("Loading saved word: ");
                char[] word = { _one.Last(), _two.Last(), _three.Last(), _four.Last(), _five.Last() };
                Console.WriteLine(word);
            }
        }
    }
}
