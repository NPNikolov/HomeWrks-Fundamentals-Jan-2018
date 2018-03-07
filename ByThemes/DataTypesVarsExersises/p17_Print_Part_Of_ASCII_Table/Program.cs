using System;

namespace p17_Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int unicodeLower = int.Parse(Console.ReadLine());
            int unicodeUpper = int.Parse(Console.ReadLine());
            char symbol = ' ';
            for (int i = unicodeLower; i <= unicodeUpper; i++)
            {
                symbol = (char)i;
                Console.Write(symbol.ToString());
                if (i<unicodeUpper)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
