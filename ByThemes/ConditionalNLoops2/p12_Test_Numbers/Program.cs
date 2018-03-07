using System;

namespace p12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmb_a = int.Parse(Console.ReadLine());
            int nmb_b = int.Parse(Console.ReadLine());

            int nmb_UpperBound = int.Parse(Console.ReadLine());
            int sum = 0;
            int cntr = 0;
            for (int i = nmb_a; i > 0; i--)
            {
                if (sum >= nmb_UpperBound)
                {
                    break;
                }
                for (int j = 1; j <= nmb_b; j++)
                {
                    sum = sum + (3 * (i * j));
                    cntr += 1;
                    //Console.WriteLine($"{cntr} {sum}");
                    if (sum>=nmb_UpperBound)
                    {
                        break;
                    }
                }
                
            }
            Console.WriteLine($"{cntr} combinations");
            if (sum >= nmb_UpperBound)
            {
                Console.WriteLine($"Sum: {sum} >= {nmb_UpperBound}");
            }
            else
            {
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
