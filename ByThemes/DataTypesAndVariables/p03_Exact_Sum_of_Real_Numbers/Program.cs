using System;

namespace p03_Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            decimal crrntN = 0;
            for (int i = 0; i < n; i++)
            {
                crrntN = decimal.Parse(Console.ReadLine());
                sum += crrntN;
            }
            Console.WriteLine(sum);
        }
    }
}
