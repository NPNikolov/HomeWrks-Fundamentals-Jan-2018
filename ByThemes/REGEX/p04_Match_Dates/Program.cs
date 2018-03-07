using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>[0-3][0-9])([.\-\/])+(?<mnth>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
            string input = Console.ReadLine();
            MatchCollection dates = Regex.Matches(input, regex);
            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var mnth = date.Groups["mnth"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {mnth}, Year: {year}");
            }
        }
    }
}
