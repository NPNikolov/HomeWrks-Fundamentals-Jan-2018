using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03_Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = int.Parse(Console.ReadLine());
            check = check % 2;
            if (check == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
