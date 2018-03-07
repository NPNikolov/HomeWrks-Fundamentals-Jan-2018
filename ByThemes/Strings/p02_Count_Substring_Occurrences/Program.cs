using System;

namespace p02_Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string testStr = Console.ReadLine().ToLower();
            string subStr = Console.ReadLine().ToLower();
            int cntr = 0;
            
            for (int i = 0; i <= testStr.Length - subStr.Length; i++)
            {
                if (testStr.Substring(i,subStr.Length).Equals(subStr))
                {
                    cntr++;
                }
            }
            Console.WriteLine(cntr);
        }
    }
}
