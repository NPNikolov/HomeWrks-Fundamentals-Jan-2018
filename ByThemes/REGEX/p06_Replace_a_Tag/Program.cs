using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p06_Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            //string regex_replace = @"(((^|(?<=\s))(\[URL href=))$5((?!\/)\]))$7(\[\/URL\])";
            string reg_replace = @"[URL href=$1]$2[/URL]";
        string input;
            do
            {
                input = Console.ReadLine();
                if (!"end".Equals(input))
                {
                    //MatchCollection lineHtml = Regex.Matches(input, regex);
                    //Match item = lineHtml.ElementAt(0);
                    //var elm5 = item.Groups[5];
                    //var elm7 = item.Groups[7];
                    string replaced = Regex.Replace(
                        input, regex, reg_replace);
                    Console.WriteLine(replaced);
                }

            } while (!"end".Equals(input));

            
        }
    }
}
