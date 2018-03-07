using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p01_Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))[A-Za-z\d]+[\w\d-\.]*[^\.-_]@[A-Za-z]+[-]?[A-z]+(\.[A-Za-z]+[-]?[A-z]+)+";
            string input = Console.ReadLine();
            MatchCollection numbers = Regex.Matches(input, regex);
            foreach (Match item in numbers)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
