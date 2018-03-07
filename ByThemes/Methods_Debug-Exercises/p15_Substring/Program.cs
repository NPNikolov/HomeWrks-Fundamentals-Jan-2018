using System;

namespace p15_Substring
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            { 
                if (text[i] ==Search)
                {
                    hasMatch = true;

                    int endIndex = i+1+jump;

                    if (endIndex >= text.Length)
                    {
                        endIndex = Math.Min(endIndex,(text.Length - 1));
                        jump = endIndex - i;
                    }

                    string matchedString = text.Substring(i, jump+1);
                    Console.WriteLine(matchedString);
                    i = endIndex - 1;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
