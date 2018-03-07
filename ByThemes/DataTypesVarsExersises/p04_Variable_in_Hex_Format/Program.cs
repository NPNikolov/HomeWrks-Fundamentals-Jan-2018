using System;

namespace p04_Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            int to_int = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(to_int);
        }
    }
}
