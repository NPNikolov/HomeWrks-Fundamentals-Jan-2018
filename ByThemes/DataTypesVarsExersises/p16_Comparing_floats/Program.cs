using System;

namespace p16_Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double diff = firstNumber - secondNumber;
            if (eps >= Math.Abs(diff))
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");
        }
    }
}
