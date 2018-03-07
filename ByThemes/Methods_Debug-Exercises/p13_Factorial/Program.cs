using System;
using System.Numerics;

namespace p13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger nmbr = BigInteger.Parse(Console.ReadLine());
            nmbr = Factorial(nmbr);
            Console.WriteLine(nmbr);
        }
        static BigInteger Factorial(BigInteger number)
        {
            if (number ==0||number ==1)
            {
                return 1;
            }else return number * Factorial(number - 1);
        }
    }
}
