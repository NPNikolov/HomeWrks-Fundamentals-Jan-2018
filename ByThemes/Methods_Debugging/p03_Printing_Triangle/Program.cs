using System;

namespace p03_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmbr = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nmbr; i++)
            {
                PrintLineNumbers(i);
                Console.WriteLine();
            }
            for (int i = nmbr-1; i > 0; i--)
            {
                PrintLineNumbers(i);
                if (i>1)
                {
                    Console.WriteLine();
                }
            }
        }

        static void PrintLineNumbers(int nmbr)
        {
            for (int i = 1; i <= nmbr; i++)
            {
                Console.Write(i);
                if (i<nmbr)
                {
                    Console.Write(" ");
                } 
            }
        }
    }
}
