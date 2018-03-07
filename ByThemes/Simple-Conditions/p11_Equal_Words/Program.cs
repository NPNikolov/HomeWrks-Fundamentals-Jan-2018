using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1, str2;
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            if (str1.Equals(str2))
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }
}
