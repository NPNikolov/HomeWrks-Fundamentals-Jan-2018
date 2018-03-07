using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_CircleArea_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var per = Math.PI * r * 2;
            var area = Math.PI * r * r;
            Console.WriteLine(area);
            Console.WriteLine(per);
        }
    }
}
