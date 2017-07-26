using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input hyphen separated numbers ie. 2-3-1-2-4: ");
            var input = Console.ReadLine();
            var pattern = new NumberPattern(input);

            if (pattern.IsValid)
            {
                var isConsecutive = pattern.IsConsecutive();
                var resultsTable = pattern.FindDuplicates();
                PrintData p = new PrintData();
                p.Print(isConsecutive);
                p.Print(resultsTable);
            }
        }
    }
}
