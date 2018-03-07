using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_01_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name} !");
        }
    }
}
