﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_Number_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int tst = int.Parse(Console.ReadLine());
            if (tst < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (tst <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
                Console.WriteLine("Greater than 200");
        }
    }
}
