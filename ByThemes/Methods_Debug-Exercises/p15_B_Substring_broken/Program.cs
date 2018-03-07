using System;

namespace p15_B_Substring_broken
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
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = jump;

                    if (i+endIndex >= text.Length)
                    {
                        endIndex = text.Length;
                        endIndex -= i;
                    }
                    else endIndex++;

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += endIndex - 1;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
