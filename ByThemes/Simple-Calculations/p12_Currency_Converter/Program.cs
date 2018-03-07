using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12_Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp = double.Parse(Console.ReadLine());
            var from_ = Console.ReadLine();
            var to_ = Console.ReadLine();
            var bgn = 1.0;
            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;
            

            switch (from_)
            {
                case "BGN":
                    tmp = tmp * bgn;
                    break;
                case "USD":
                    tmp = tmp * usd;
                    break;
                case "EUR":
                    tmp = tmp * eur;
                    break;
                case "GBP":
                    tmp = tmp * gbp;
                    break;
            }
            switch (to_)
            {
                case "BGN":
                    tmp = tmp / bgn;
                    break;
                case "USD":
                    tmp = tmp / usd;
                    break;
                case "EUR":
                    tmp = tmp / eur;
                    break;
                case "GBP":
                    tmp = tmp / gbp;
                    break;
            }
            tmp = Math.Round(tmp, 2);
            Console.WriteLine(tmp);
        }
    }
}
