﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02_Excellent_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            if (score >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else Console.WriteLine("Not excellent.");
        }
    }
}
