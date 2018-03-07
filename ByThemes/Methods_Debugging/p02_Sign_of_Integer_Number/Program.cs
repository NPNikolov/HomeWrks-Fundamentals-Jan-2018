using System;

namespace p02_Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nmbr = int.Parse(Console.ReadLine());
            PrintSignNumber(Nmbr);
        }
        static void PrintSignNumber(int Nmbr)
        {
            if (Nmbr>0)
            {
                Console.WriteLine($"The number {Nmbr} is positive.");
            }
            else if (Nmbr<0)
            {
                Console.WriteLine($"The number {Nmbr} is negative.");
            }else Console.WriteLine($"The number {Nmbr} is zero.");
        }
    }
}
