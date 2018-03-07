using System;

namespace p07_Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            long testNumber = long.Parse(Console.ReadLine());
            bool reslt = false;
            if (testNumber>1)
            {
                reslt =  IsPrimeNmbr(testNumber);
            }
            Console.WriteLine(reslt);
        }

        static bool IsPrimeNmbr(long testNumber)
        {
            bool isPrime = true;
            for (int devider = 2; devider <= Math.Sqrt(testNumber); devider++)
            {
                if (testNumber % devider == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
