using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p02_Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @" ?\+359( |-)2\1[0-9]{3}\1[0-9]{4}";
            string input = Console.ReadLine();
            MatchCollection matched = Regex.Matches(input, regex);
            var matchedPhones = matched.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
