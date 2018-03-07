using System;

namespace p14_Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            string to_hex = digit.ToString("X");
            string to_bin = Convert.ToString(digit,2);
            Console.WriteLine(to_hex);
            Console.WriteLine(to_bin);
        }
    }
}
