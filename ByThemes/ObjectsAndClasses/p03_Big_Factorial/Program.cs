using System;
using System.Numerics;

namespace p03_Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger rslt = 1;
            for (int i = 1; i <= n; i++)
            {
                rslt *= i;
            }
            Console.WriteLine(rslt);
        }
    }
}
