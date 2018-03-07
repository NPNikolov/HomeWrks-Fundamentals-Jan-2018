using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15_3Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            String res = "yes";
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            if (a != b)
            {
                res = "no";
            }
            else if (a != c)
            {
                res = "no";
            }
            Console.WriteLine(res);
        }
    }
}
