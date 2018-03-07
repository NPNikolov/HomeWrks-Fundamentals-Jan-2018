using System;

namespace p04_Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n+1];
            for (int i = 0; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;
            for (int i = 2; i < n; i++)
            {
                if (primes[i])
                {
                    
                    for (int j = 2; j < n; j++)
                    {
                        if (j * i > n)
                        {
                            break;
                        }
                        else primes[j * i] = false;
                    }
                }
            }
            for (int i = 0; i <= n; i++)
            {
                if (primes[i])
                {
                    if (i>2)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(i);
                }
            }
        }
    }
}
