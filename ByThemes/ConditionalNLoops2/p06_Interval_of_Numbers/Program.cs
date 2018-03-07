using System;

namespace p06_Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int min = Math.Min(num1, num2);
            if (num2==min)
            {
                num2 = num1;
            }
            for (int i = min; i <= num2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
