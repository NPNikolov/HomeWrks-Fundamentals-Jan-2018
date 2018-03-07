using System;

namespace p05_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibNmbr = 0;
            
                fibNmbr = FibNmbr(n);
                Console.WriteLine(fibNmbr);
            
        }

        static int FibNmbr(int n)
        {
            int reslt = 0;
            if (n==0)
            {
                reslt = 1;
            }
            else if (n==1)
            {
                reslt = 1;
            }
            else
            {
                reslt = FibNmbr(n - 1) + FibNmbr(n - 2);
            }
            return reslt;
        }
    }
}
