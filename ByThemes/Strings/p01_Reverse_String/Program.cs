using System;

namespace p01_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string testIn = Console.ReadLine();
            char[] reverse = testIn.ToCharArray();
            Array.Reverse(reverse);
            testIn = string.Join("", reverse);
            Console.WriteLine(testIn);
        }
    }
}
