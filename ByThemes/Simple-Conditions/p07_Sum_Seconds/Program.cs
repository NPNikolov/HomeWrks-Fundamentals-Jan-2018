using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07_Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3, sum_sec, nm_min, nm_sec;
            s1 = int.Parse(Console.ReadLine());
            s2 = int.Parse(Console.ReadLine());
            s3 = int.Parse(Console.ReadLine());
            sum_sec = s1 + s2 + s3;
            nm_min = sum_sec / 60;
            nm_sec = sum_sec - (nm_min * 60);
            String str = "";
            if (nm_sec < 10)
            {
                str = "0" + nm_sec;
            }
            else str = "" + nm_sec;
            str = "" + nm_min + ":" + str;
            Console.WriteLine(str);
        }
    }
}
