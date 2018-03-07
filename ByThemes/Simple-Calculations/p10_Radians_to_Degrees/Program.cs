using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rads = double.Parse(Console.ReadLine());
            var grds = rads * 180.0 / Math.PI;
            grds = Math.Round(grds, 2);
            Console.WriteLine(grds);
        }
    }
}
