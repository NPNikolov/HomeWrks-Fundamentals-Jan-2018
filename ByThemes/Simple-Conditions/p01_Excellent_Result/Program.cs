using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_Excellent_Result
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
        }
    }
}
