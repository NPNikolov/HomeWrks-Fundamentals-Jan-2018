using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int in_nm = int.Parse(Console.ReadLine());
            double scr = 0;
            if (in_nm <= 100)
            {
                scr = 5;
            }
            else if (in_nm <= 1000)
            {
                scr = in_nm * 0.2;
            }
            else
            {
                scr = in_nm * 0.1;
            }
            if (0 == in_nm % 2)
            {
                scr = scr + 1;
            }
            double rmn = in_nm / 10.0;
            rmn = rmn - in_nm / 10;
            if (rmn == 0.5)
            {
                scr = scr + 2;
            }
            Console.WriteLine(scr);
            scr = in_nm + scr;
            Console.WriteLine(scr);
        }
    }
}
