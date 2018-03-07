using System;

namespace p06_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int fromNmbr = int.Parse(Console.ReadLine());
            int upperMnbr = int.Parse(Console.ReadLine());
            string reslt = "";
            reslt = ReturnPrimeList(fromNmbr, upperMnbr);
            Console.WriteLine(reslt);
        }
        static string ReturnPrimeList(int fromNmbr, int upperMnbr)
        {
            fromNmbr = Math.Max(2, fromNmbr);
            string reslt = "";
            for (int i = fromNmbr; i <= upperMnbr; i++)
            {
                if (IsPrimeNmbr(i))
                {
                    if (reslt == "")
                    {
                        reslt = reslt + i;
                    }
                    else
                    {
                        reslt = reslt + ", " + i;
                    }
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
