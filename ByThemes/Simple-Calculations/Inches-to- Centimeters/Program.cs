using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to__Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            inches = inches * 2.54;
            Console.WriteLine(inches);
        }
    }
}
