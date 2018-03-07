using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04_Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstnm = Console.ReadLine();
            var lastnm = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var city = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstnm, lastnm, age, city);
        }
    }
}
