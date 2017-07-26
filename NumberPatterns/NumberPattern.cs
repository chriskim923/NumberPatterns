using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class NumberPattern
    {
        private string input { get; }
        public bool IsValid { get; }

        public NumberPattern(string str)
        {
            this.input = str;
            this.IsValid = IsValidInput(str);
        }

        public static bool IsValidInput(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Entry was null or whitespace");
                return false;
            }
                
            var numbers = input.Split('-');
            foreach (var number in numbers)
                if (!Int32.TryParse(number, out int n))
                {
                    Console.WriteLine("Invalid entry");
                    return false;
                }

            return true;
        }

        public bool IsConsecutive()
        // Checks if "-" separated numbers are consecutive
        {
            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            int initialDiff = numbers[0] - numbers[1];
            if (Math.Abs(initialDiff) != 1)
                return false;

            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i-1] - numbers[i] != initialDiff)
                {
                    return false;
                }
            }
            return true;
        }

        public Dictionary<string, int> FindDuplicates()
        // Checks if "-" separated numbers have any duplicates
        {
            var numbers = new List<string>();
            foreach (var number in input.Split('-'))
                numbers.Add(number);

            numbers.Sort();
            var unique_items = new HashSet<string>(numbers);
            var countTable = new Dictionary<string, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!countTable.ContainsKey(numbers[i]))
                {
                    countTable[numbers[i]] = 1;
                }
                else
                {
                    countTable[numbers[i]] += 1;
                }
            }

            return countTable;
        }
        
    }
}
