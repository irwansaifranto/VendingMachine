using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Should print "flo", "fle", and "fla" since those are the distinct, length 3 prefixes.
            foreach (var p in AllPrefixes(3, new string[] { "flow", "flowers", "flew", "flag", "fm" }))
                Console.WriteLine(p);
        }

        public static IEnumerable<string> AllPrefixes(int prefixLength, IEnumerable<string> words)
        {
            IEnumerable<string> result = words.Where(x => x.Length >= 3).Select(x => x.Substring(0, 3)).Distinct();
            return result;
        }
    }
}
