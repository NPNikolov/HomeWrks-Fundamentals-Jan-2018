using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12_Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double vlc = double.Parse(Console.ReadLine());
            if (vlc <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (vlc <= 50)
            {
                Console.WriteLine("average");
            }
            else if (vlc <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (vlc <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else Console.WriteLine("extremely fast");
        }
    }
}
