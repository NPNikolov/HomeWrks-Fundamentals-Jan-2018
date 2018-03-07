using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_08_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var ha = double.Parse(Console.ReadLine());
            var s = a * ha / 2;
            s = Math.Round(s, 2);
            Console.WriteLine(s);
        }
    }
}
