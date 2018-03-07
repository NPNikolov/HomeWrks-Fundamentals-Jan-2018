using System;

namespace p07_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double powered = CalcPower(number, power);
            Console.WriteLine(powered);
        }

        static double CalcPower(double number, int power)
        {
            double tmp = 1;
            for (int i = 1; i <= power; i++)
            {
                tmp *= number;
            }
            return tmp;
        }
    }
}
