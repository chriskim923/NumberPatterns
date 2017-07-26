using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class PrintData
    {
        public void Print(bool isConsecutive)
        {
            var msgConsecutive = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(msgConsecutive);
        }

        public void Print(Dictionary<string, int> resultsTable)
        {
            foreach (KeyValuePair<string, int> entry in resultsTable)
            {
                Console.WriteLine("Number-{0} : Count-{1}", entry.Key, entry.Value.ToString());
            }
        }
    }
}
