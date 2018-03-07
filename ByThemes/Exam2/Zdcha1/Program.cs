using System;

namespace Zdcha1
{
    class Program
    {
        static void Main(string[] args)
        {
            double amntMny = double.Parse(Console.ReadLine());
            int nmbrStdnts = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int nmbrFreeBelts = nmbrStdnts / 6;
            int nmbrSabres = (int)Math.Ceiling(1.1 * nmbrStdnts);
            double res = nmbrStdnts * robePrice + (nmbrStdnts - nmbrFreeBelts) * beltPrice + nmbrSabres * sabrePrice;
            if (amntMny>=res)
            {
                Console.WriteLine($"The money is enough - it would cost {res:f2}lv.");
            }
            else
            {
                double neededMoney = res - amntMny;
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }

        }
    }
}
