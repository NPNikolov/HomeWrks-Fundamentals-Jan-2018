using System;
using System.Text.RegularExpressions;

namespace p01_Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ {1}[A-Z][a-z]+\b";
            string names = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(names, regex);
            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value+" ");
            }
        }
    }
}
