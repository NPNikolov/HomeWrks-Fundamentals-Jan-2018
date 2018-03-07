using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14_Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hr, min, newmin;
            hr = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());
            newmin = min + 15;
            if (newmin > 59)
            {
                newmin = newmin - 60;
                if (hr == 23)
                {
                    hr = 0;
                }
                else hr = hr + 1;
            }
            
            string minstr;
            if (newmin < 10)
            {
                minstr = "0" + newmin;
            } else minstr = "" + newmin;
            Console.WriteLine(hr + ":" + minstr);
            
        }
    }
}
