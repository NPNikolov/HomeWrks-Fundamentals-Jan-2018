using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace p02_Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedWord = Console.ReadLine();
            string patternSentence = @"(^|(?<=\W))[^\s].*?[\.\?\!]";
            string pattern = @"\W" + searchedWord + "\\W";
            string input = Console.ReadLine();
            MatchCollection sentences = Regex.Matches(input, patternSentence);
            var regex = new Regex(pattern);
            foreach (Match item in sentences)
            {
                string sentence = item.Value;
                if (regex.IsMatch(sentence))
                {
                    string[] strArr = sentence.Split(new char[] { '.', '!', '?' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                    Console.WriteLine(strArr[0]);
                }
                
            }

        }
    }
}
