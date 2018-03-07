using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09_Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            String pss = Console.ReadLine();
            String sample = "s3cr3t!P@ssw0rd";
            if (sample.Equals(pss))
            {
                Console.WriteLine("Wellcome");
            }
            else Console.WriteLine("Wrong password!");
        }
    }
}
