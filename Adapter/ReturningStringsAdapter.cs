using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    internal static class ReturningStringsAdapter
    {
        private readonly static ReturningStrings _returningStrings = new();
        private readonly static PrintingInts _printingInts = new();

        public static void PrintInts()
        {
            if (int.TryParse(_returningStrings.ReturnString(), out int number))
                _printingInts.Print(number);
            else
                throw new ArgumentException(
                    "ReturningStrings has been altered. " +
                    "Your system may be compromized. " +
                    "Step away from the computer immediately and await further instructions."
                    );
        }
    }
}
