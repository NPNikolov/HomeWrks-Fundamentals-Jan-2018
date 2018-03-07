using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, mm, cm, mi, inc, km, ft, yd, tmp;

            m = 1.0;
            mm = 0.001;
            cm = 0.01;
            mi = 1 / 0.000621371192;
            inc = 1 / 39.3700787;
            km = 1000.0;
            ft = 1 / 3.2808399;
            yd = 1 / 1.0936133;

            String from_, to_;
            tmp = double.Parse(Console.ReadLine());
            from_ = Console.ReadLine();
            to_ = Console.ReadLine();

            switch (from_)
            {
                case "m":
                    tmp = tmp * m;
                    break;
                case "mm":
                    tmp = tmp * mm;
                    break;
                case "cm":
                    tmp = tmp * cm;
                    break;
                case "mi":
                    tmp = tmp * mi;
                    break;
                case "in":
                    tmp = tmp *inc;
                    break;
                case "km":
                    tmp = tmp * km;
                    break;
                case "ft":
                    tmp = tmp * ft;
                    break;
                case "yd":
                    tmp = tmp * yd;
                    break;
            }
            switch (to_)
            {
                case "m":
                    tmp = tmp / m;
                    break;
                case "mm":
                    tmp = tmp / mm;
                    break;
                case "cm":
                    tmp = tmp / cm;
                    break;
                case "mi":
                    tmp = tmp / mi;
                    break;
                case "in":
                    tmp = tmp /inc;
                    break;
                case "km":
                    tmp = tmp / km;
                    break;
                case "ft":
                    tmp = tmp / ft;
                    break;
                case "yd":
                    tmp = tmp / yd;
                    break;
            }
            tmp = Math.Round(tmp, 8);
            Console.WriteLine(tmp);
            
        }
    }
}
