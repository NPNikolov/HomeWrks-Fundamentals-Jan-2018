using System;
using System.Collections.Generic;

namespace p07_BPrimes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int fromNmbr = int.Parse(Console.ReadLine());
            int upperMnbr = int.Parse(Console.ReadLine());
            
            var reslt = ReturnPrimeList(fromNmbr, upperMnbr);

            PrintMyList(reslt);
            
        }

        static void PrintMyList(List<int> reslt)
        {
            for (int i = 0; i < reslt.Count; i++)
            {
                if (i>0)
                {
                    Console.Write(", ");
                }
                Console.Write(reslt[i]);
            }
        }

        static List<int> ReturnPrimeList(int fromNmbr, int upperMnbr)
        {
            fromNmbr = Math.Max(2, fromNmbr);
            var reslt = new List<int>();
            for (int i = fromNmbr; i <= upperMnbr; i++)
            {
                if (IsPrimeNmbr(i))
                {
                    reslt.Add(i);
                }
            }
            return reslt;
        }
        static bool IsPrimeNmbr(int testNumber)
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
