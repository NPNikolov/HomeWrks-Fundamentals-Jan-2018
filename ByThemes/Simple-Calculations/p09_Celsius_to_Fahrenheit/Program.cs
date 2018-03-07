using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09_Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var cls = double.Parse(Console.ReadLine());
            var far = cls * 1.8 + 32;
            far = Math.Round(far, 2);
            Console.WriteLine(far);
        }
    }
}
