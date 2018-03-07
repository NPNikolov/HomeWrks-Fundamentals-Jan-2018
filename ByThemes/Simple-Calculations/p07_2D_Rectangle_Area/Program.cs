using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var area = Math.Abs((x2 - x1) * (y1 - y2));
            var per = 2* Math.Abs((x2 - x1)) +2*Math.Abs((y1 - y2));
            Console.WriteLine(area);
            Console.WriteLine(per);

        }
    }
}
