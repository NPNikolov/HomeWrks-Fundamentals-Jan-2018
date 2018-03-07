using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p05_Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))(\-|\+)?[0-9]+(\.[\d]+)*($|(?=\s))";
            string input = Console.ReadLine();
            MatchCollection numbers = Regex.Matches(input, regex);
            foreach (Match item in numbers)
            {
                Console.Write(item.Value+" ");
            }
        }
    }
}
