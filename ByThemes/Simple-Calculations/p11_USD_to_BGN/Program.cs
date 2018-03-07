using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            usd = Math.Round((usd * 1.79549), 2);
            Console.WriteLine(usd);
        }
    }
}
