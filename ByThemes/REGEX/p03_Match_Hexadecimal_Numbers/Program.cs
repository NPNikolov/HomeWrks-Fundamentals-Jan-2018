using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p03_Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(0x)?([0-9]+|[A-F]+)+\b";
            string input = Console.ReadLine();
            MatchCollection matched = Regex.Matches(input, regex);
            var matchedNumbers = matched.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(" ", matchedNumbers));
        }
    }
}
