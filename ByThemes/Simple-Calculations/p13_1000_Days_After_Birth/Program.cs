using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace p13_1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var str_dt = Console.ReadLine();
            string format;
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime reslt;
            format = "dd-MM-yyyy";
            reslt = DateTime.ParseExact(str_dt, format,provider);
            reslt = reslt.AddDays(999);

            Console.WriteLine(reslt.ToString(format));
        }
    }
}
