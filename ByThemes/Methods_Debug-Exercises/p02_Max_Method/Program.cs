using System;

namespace p02_Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            num1 = GetMax(num1, num2);
            num2 = int.Parse(Console.ReadLine());
            num2 = GetMax(num1, num2);
            Console.WriteLine(num2);

        }

        static int GetMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
    }
}
