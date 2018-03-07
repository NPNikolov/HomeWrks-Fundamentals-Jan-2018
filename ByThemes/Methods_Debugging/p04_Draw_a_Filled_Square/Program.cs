using System;

namespace p04_Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmbr = int.Parse(Console.ReadLine());
            PrintLine(nmbr);
            Console.WriteLine();
            for (int i = 2; i < nmbr; i++)
            {
                PrintMiddleLine(nmbr);
            }
            PrintLine(nmbr);
        }

        private static void PrintMiddleLine(int nmbr)
        {
            Console.Write("-");
            for (int i = 1; i < nmbr; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        static void PrintLine(int nmbr)
        {
            for (int i = 0; i < nmbr; i++)
            {
                Console.Write("--");
            }
        }
    }
}
