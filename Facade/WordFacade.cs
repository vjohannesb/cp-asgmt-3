using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    internal static class WordFacade
    {
        internal static void Save()
        {
            string input = null;
            while (string.IsNullOrEmpty(input) || input.Length != 5)
            {
                Console.Write("Enter a word with precisely 5 characters: ");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Saving {input}...");
            WordLegacy.Save(input);
        }

        internal static void Load()
        {
            if (WordLegacy.One.Count > 0)
            {
                Console.Write("Loading saved word: ");
                WordLegacy.Load();
            }
            else Console.WriteLine("Nothing to load. Try saving something first.");
        }
    }
}
