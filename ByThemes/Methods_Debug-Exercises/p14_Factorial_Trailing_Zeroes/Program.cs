using System;
using System.Numerics;

namespace p14_Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger nmbr = BigInteger.Parse(Console.ReadLine());
            nmbr = Factorial(nmbr);
            int nmbrZeroes = CountZeroesInNmbr(nmbr);
            Console.WriteLine(nmbrZeroes);
        }

        static int CountZeroesInNmbr(BigInteger tstNmbr)
        {
            int nmbr = 0;
            BigInteger hlpNmbr = tstNmbr;
            BigInteger lastDigit = 0;
            while (lastDigit==0&&hlpNmbr>=10)
            {
                lastDigit = hlpNmbr % 10;
                if (lastDigit==0)
                {
                    nmbr++;
                }
                hlpNmbr /= 10;
            }

            return nmbr;
        }

        static BigInteger Factorial(BigInteger number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else return number * Factorial(number - 1);
        }
    }
}
